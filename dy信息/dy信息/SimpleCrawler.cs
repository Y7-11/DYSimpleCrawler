using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dy信息
{
   public class SimpleCrawler
    {
        public event EventHandler<OnStartEventArgs> OnStart;//爬虫启动事件
        public event EventHandler<OnCompletedEventArgs> OnCompleted;//爬虫完成事件
        public event EventHandler<Exception> OnError;//爬虫出错事件
        public CookieContainer CookiesContainer { get; set; }//cookie容器
        public SimpleCrawler() { }

        public async Task<string> Start(Uri uri, WebProxy proxy = null)
        {
            return await Task.Run(() =>
            {
                var PageSource = string.Empty;
                try
                {
                    if (this.OnStart != null) this.OnStart(this, new OnStartEventArgs(uri));
                    var watch = new Stopwatch();
                    watch.Start();
                    HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                    request.Accept = "*/*";
                    request.ContentType = "application/x-www-form-urlencoded";//定义文档类型及编码
                    request.AllowAutoRedirect = false;
                    request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko)Chrome/50.0.2661.102 Safari/537.36";
                    request.Timeout = 5000;
                    request.KeepAlive = true;
                    request.Method = "GET";
                    if (proxy != null) request.Proxy = proxy;
                    request.CookieContainer = CookiesContainer;
                    request.ServicePoint.ConnectionLimit = int.MaxValue;
                    var response = (HttpWebResponse)request.GetResponse();
                    foreach (Cookie cookie in response.Cookies) this.CookiesContainer.Add(cookie);
                    var stream = response.GetResponseStream();
                    var read = new StreamReader(stream, Encoding.UTF8);
                    PageSource = read.ReadToEnd();
                    watch.Stop();
                    var threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
                    var milliseconds = watch.ElapsedMilliseconds;
                    read.Close();
                    stream.Close();
                    request.Abort();
                    response.Close();
                    if (this.OnCompleted != null) this.OnCompleted(this, new OnCompletedEventArgs(uri, threadId, milliseconds, PageSource));
                }
                catch (Exception ex)
                {

                    if (this.OnError != null)
                        this.OnError(this, ex);
                }
                return PageSource;
            });
        }

        public class OnStartEventArgs
        {
            public Uri Uri { get; set; }//爬虫地址
            public OnStartEventArgs(Uri uri)
            {
                this.Uri = uri;
            }
        }
        public class OnCompletedEventArgs
        {
            public Uri Uri { get; private set; }//爬虫Uri地址
            public int ThreadId { get; private set; }//任务线程ID
            public string PageSource { get; private set; }//页面源代码
            public long Milliseconds { get; private set; }//爬虫请求执行事件
            public OnCompletedEventArgs(Uri uri, int threadId, long milliseconds, string pagesource)
            {
                this.Uri = uri;
                this.ThreadId = threadId;
                this.Milliseconds = milliseconds;
                this.PageSource = pagesource;
            }
        }
    }
}
