using ConfigServices;
using LogServices;
using MailServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
namespace draft
{
    internal class Part_2_25_dotNET_DI
    {
       static void Main(string[] args)
        {
          ServiceCollection services = new ServiceCollection();
            //services.AddScoped<ILogProvider, ConsoleLogProvider>();

            //services.AddScoped(typeof(IConfigService),s=>new IniFileConfigService
            //{
            //    FilePath = "C:\\Users\\15283\\source\\repos\\Draft\\ConsoleApp1\\mail.ini"
            //});
           services.AddScoped<IConfigService, EnvVarConfigService>();
            services.AddIniFileConfig("mail.ini");
           
          
            services.AddLayeredConfig();
            
            //services.AddScoped<IConfigService, ConfigService>();
            services.AddScoped<IMailService, MailService>();
            services.AddConsoleLog();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                //对于第一个根服务器只能GetRequiredService
                var mailService=sp.GetRequiredService<IMailService>();
                mailService.Send("Hello ", "chq@.gov", "This is a test email.");   
            }

        }
    }

}







