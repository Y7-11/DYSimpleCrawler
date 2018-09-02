using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dy信息
{
   public static class LOG
    {
        private static object obj = new object();
        private static string LogDir = "C:\\LOG";

        public static void WriteLog(string msg)
        {
            lock (obj)
            {
                if (!Directory.Exists(LogDir))
                {
                    Directory.CreateDirectory(LogDir);
                }
                string logpath = Path.Combine(LogDir, DateTime.Now.ToString("yyyyMMdd") + ".txt");
                msg = "================================" + "\r\n" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "\r\n" + msg + "\r\n";
                File.AppendAllText(logpath, msg, Encoding.UTF8);
            }
        }
    }
}
