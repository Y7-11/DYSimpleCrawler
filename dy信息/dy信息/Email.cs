using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace dy信息
{
   public class Email
    {
        public string smtpService = "smtp.qq.com";
        public string sendEmail = "";
        public string reciveemail = "";
        //public string sendpwd = "klmewxizqsyxbefb";
        public string sendpwd = "";

        public event EventHandler<OnStartSend> onStart;
        public event EventHandler<OnOverSend> onOver;

        public async Task<bool> StartSend(string email, info info)
        {
            return await Task.Run(() =>
            {
                LOG.WriteLog("邮件开始发送");
                if (this.onStart != null) this.onStart(this, new OnStartSend(email, info));
                SmtpClient smtpclient = new SmtpClient();
                smtpclient.Host = smtpService;
                MailAddress sendAddress = new MailAddress(sendEmail);
                MailAddress receiverAddress = new MailAddress(email);

                MailMessage message = new MailMessage(sendAddress, receiverAddress);
                message.Subject = info.Name;
                message.SubjectEncoding = Encoding.UTF8;
                message.Body = info.roomname;
                message.BodyEncoding = Encoding.UTF8;
                smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpclient.EnableSsl = true;
                smtpclient.UseDefaultCredentials = false;
                try
                {
                    NetworkCredential senderCredential = new NetworkCredential(sendEmail, sendpwd);
                    smtpclient.Credentials = senderCredential;
                    smtpclient.Send(message);
                    if (this.onOver != null) this.onOver(this, new OnOverSend(email));
                    LOG.WriteLog("邮件发送成功");
                    return true;
               
                }
                catch(Exception e)
                {
                    LOG.WriteLog("邮件发送失败:" + e.Message);
                    return false;
           
                }
            });
        }
    }

   public class OnStartSend
   {
       public info info { get; set; }
       public string reciveemail { get; set; }
       public OnStartSend(string reviceemail, info info)
       {
           this.reciveemail = reviceemail;
           this.info = info;
       }
   }
   public class OnOverSend
   {
       public string reciveemail { get; set; }
       public OnOverSend(string reviceemail)
       {
           this.reciveemail = reciveemail;
       }
   }
}
