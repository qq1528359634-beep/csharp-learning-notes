using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace JasonExample
{
    internal class TextController
    {
        private readonly IOptionsSnapshot<Config> optConfig;

        public TextController(IOptionsSnapshot<Config> config)
        {
            this.optConfig = config;
        }
        public void Test()
        {   Config config = optConfig.Value;
            Console.WriteLine(config.Name);
            Console.WriteLine("******************");
            Console.WriteLine(config.Age);
            Console.WriteLine(config.Proxy.Address);
            Console.WriteLine(config.Proxy.Port);
            Console.WriteLine(string.Join(",",config.Proxy.Ids));
        }
    }
    
}
