using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using LogServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static  class ConsoleLogExtensions
    {
        public static  void AddConsoleLog(this IServiceCollection services)
        {
            services.AddScoped<ILogProvider, ConsoleLogProvider>();
        }
    }
}
