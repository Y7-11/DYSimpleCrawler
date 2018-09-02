using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dy信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.ControlBox = false;
            this.MaximizeBox = false;

            cityCrawler = new SimpleCrawler();
            cityCrawler.OnStart += (s, e) =>
            {
                LOG.WriteLog("爬虫开始抓取地址:" + e.Uri.ToString());
                //this.Invoke(new Action(() =>
                // {
                //     tb_msg.Text += "==============================="+"\r\n";
                //     tb_msg.Text += "爬虫开始抓取地址:" + e.Uri.ToString()+"\r\n";
                // }));
            };

            cityCrawler.OnError += (s, e) =>
            {
                LOG.WriteLog("爬虫抓取出现错误:" + e.Message);
                MessageBox.Show("爬虫抓取出现错误:" + e.Message);
                //this.Invoke(new Action(() =>
                //        {
                //            tb_msg.Text += "===============================" + "\r\n";
                //            tb_msg.Text += "爬虫抓取出现错误:" + e.Message + "\r\n";
                //        }));
            };
            cityCrawler.OnCompleted += (s, e) =>
            {
                var roomtitle = Regex.Matches(e.PageSource, @"(?<=<h2>).*(?=</h2>)"
                             , RegexOptions.IgnoreCase);
                var ZBName = Regex.Matches(e.PageSource, @"(?<=<h1>).*(?=</h1>)"
                  , RegexOptions.IgnoreCase);
                var lasttime = Regex.Matches(e.PageSource, @"(?<=<a data-anchor-info=""timetit"">).*(?=</a>)"
                  , RegexOptions.IgnoreCase);

                this.Invoke(new Action(() =>
                {
                    try
                    {
                        lbl_name.Text = ZBName[0].ToString();
                        lbl_room.Text = roomtitle[0].ToString();
                        lbl_last.Text = lasttime[0].ToString();
                        if (firstbtn)
                        {
                            roomname = lbl_room.Text;
                            firstbtn = false;
                        }
                        LOG.WriteLog("主播：" + lbl_name.Text + "\r\n" + "房间号：" + lbl_room.Text + "\r\n" + "上次直播：" + lbl_last.Text);


                        //tb_msg.Text += "===============================" + "\r\n";
                        //tb_msg.Text += "主播：" + lbl_name.Text + "\r\n" + "房间号：" + lbl_room.Text + "\r\n" + "上次直播：" + lbl_last.Text + "\r\n";

                    }
                    catch (Exception ex)
                    {
                        LOG.WriteLog("房间号不对或者不能爬取，请输入正确的房间号！error:"+ex.Message);
                        MessageBox.Show("房间号不对或者爬取失败,error:"+ex.Message);
                  //      this.Invoke(new Action(() =>
                  //{
                  //    tb_msg.Text += "===============================" + "\r\n";
                  //    tb_msg.Text += "房间号不对，请输入正确的房间号！" + "\r\n";
                  //}));
                        //MessageBox.Show("房间号不对或者不能爬取，请输入正确的房间号！");
                    }
                }));
                LOG.WriteLog("爬虫抓取完毕");
   //             this.Invoke(new Action(() =>
   //{
   //    tb_msg.Text += "===============================" + "\r\n";
   //    tb_msg.Text += "爬虫抓取完毕" + "\r\n";
   //}));
            };
        }
        public SimpleCrawler cityCrawler = null;
        string cityUrl = "";
        System.Timers.Timer t=new System.Timers.Timer();
        Email email = new Email();
        string roomname = null;
        bool isSendEmail = false;
        bool firstbtn = false;
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs ee)
        {

            await Task.Run(() =>
            {
                if (tb_room.Text=="71017")
                {
                    MessageBox.Show("不提供晦气主播的查询");
                    return;
                }
                cityUrl = "https://www.douyu.com/";
                cityUrl += tb_room.Text;                
                firstbtn = true;
                cityCrawler.Start(new Uri(cityUrl)).Wait();
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_time.Text))
            {
                MessageBox.Show("请输入轮询时间");
                return;
            }
            var time = MessageBox.Show("轮询时间：" + tb_time.Text, "确认", MessageBoxButtons.YesNo);
            if (time == DialogResult.No)
            {
                tb_time.Text = "";
            }
            //发送邮件
            if (!string.IsNullOrEmpty(tb_email.Text)&&!string.IsNullOrEmpty(tb_sendEmail.Text)&&!string.IsNullOrEmpty(tb_sendpwd.Text))
            {
                if (Regex.Matches(tb_email.Text, @"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z0-9]{2,6}$").Count <= 0)
                {
                    MessageBox.Show("请输入正确的邮箱");
                    return;
                }
                var result = MessageBox.Show("如果房间名发送改变将发送邮件到：" + tb_email.Text, "确认", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    tb_email.Text = "";
                }            
                email.reciveemail = tb_email.Text;
                email.sendEmail = tb_sendEmail.Text;
                email.sendpwd = tb_sendpwd.Text;

                isSendEmail = true;
                //lbl_isok.Text = "邮件设置成功！";
                tb_msg.Text += "邮件设置成功！/n";
                LOG.WriteLog("邮件设置成功："+tb_email.Text);
            }
            else
            {
                MessageBox.Show("邮箱设置失败,请检查接收邮箱、发送邮箱、发送密码是否输入正确");
                LOG.WriteLog("邮箱设置失败：" + tb_email.Text);
                return;
            }
            if (t.Enabled==true)
            {            
                if (t.Interval!= 60000*int.Parse(tb_time.Text))
                {
                    t.Stop();
                    t.Close();
                    t.Dispose();
                    t.Enabled = false;
                }
                
            }
            if (!t.Enabled)
            {
                t = new System.Timers.Timer();
                t.AutoReset = true;

                t.Interval = 60000 * int.Parse(tb_time.Text);
                t.Elapsed += t_Elapsed;
                t.Enabled = true;
                //lbl_timeok.Text = "轮询设置成功！";
                tb_msg.Text += "轮询设置成功！/n";
                LOG.WriteLog("轮询设置成功！");
                //MessageBox.Show("设置成功");
            }
       
        }

        void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_room.Text))
            {
                MessageBox.Show("请输入房间号");
                return;
            }
            cityCrawler.Start(new Uri(cityUrl)).Wait();
            if (isSendEmail)
            {
                 if (roomname != lbl_room.Text)
                {
                    roomname = lbl_room.Text;
                    //string emailMsg = lbl_room.Text;
                    info Msg = new info();
                    Msg.Name = lbl_name.Text;
                    Msg.roomname = lbl_room.Text;
                    email.StartSend(email.reciveemail, Msg).Wait();
                
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => {
                tb_msg.Text += "注意：只能抓取部分房间的信息，抓取不到的将显示房间号错误！！" + "\r\n" + "\r\n";
                tb_msg.Text += "轮询时间为循环查询时间间隔" + "\r\n" + "\r\n";
                tb_msg.Text += "设置邮箱后当房间标题发生改变会发一封邮件到该邮箱" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n";
                //tb_msg.Text += "             ----by 67373" + "\r\n" ;
            }));
        }

        private void btn_quxiaoSend_Click(object sender, EventArgs e)
        {
            if (isSendEmail==true)
            {
                isSendEmail = false;
                tb_email.Text = "";
                lbl_isok.Text = "邮件已取消！";
                LOG.WriteLog("邮件已取消：");
            }
       
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            } 
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？","退出",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                LOG.WriteLog("程序退出");
                this.Dispose();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t.Enabled==true)
            {
                t.Stop();
                t.Enabled = false;
                t.Close();
                t.Dispose();
                lbl_timeok.Text = "轮询已取消";
                LOG.WriteLog("轮询已取消");
            }
         
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
