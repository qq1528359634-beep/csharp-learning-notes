using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace ConfigServices
{
    public static  class IniFileConfigExtensions
    {
        public static  void AddIniFileConfig(this IServiceCollection services,string path)
        {
            services.AddScoped(typeof(IConfigService), s => new IniFileConfigService
            {
                FilePath = path
            });
        }
    }
}
