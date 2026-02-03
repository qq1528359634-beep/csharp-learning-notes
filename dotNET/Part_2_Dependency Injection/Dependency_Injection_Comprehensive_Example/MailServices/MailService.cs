using LogServices;
using ConfigServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailServices
{
    public  class MailService : IMailService
    {
        private readonly ILogProvider log;
        //private readonly IConfigService config;
        private readonly IConfigReader config;
       // public MailService(ILogProvider log, IConfigService config)
        public MailService(ILogProvider log, IConfigReader config)
        {
            this.log = log;
            this.config = config;
        }   
        public void Send(string title, string to, string body)
        {   
            this.log.LogInfo($"Ready Sending mail to {to} with title {title}");
           string smtpServer= this.config.GetValue("SmtpServer");
           string smtpServer1= this.config.GetValue("UserName");
           string smtpServer2= this.config.GetValue("PassWord");
            Console.WriteLine($"mail server  address {smtpServer} {smtpServer1 } {smtpServer2}");
            Console.WriteLine($"Mail have been sent!");
            this.log.LogInfo($"Mail to {to} with title {title} have been sent");
        }
    }
}
