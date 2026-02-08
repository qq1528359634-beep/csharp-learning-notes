using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace JasonExample
{
    internal class TestWebConfig
    {
        private IOptionsSnapshot<WebConfig> optWC;
        public TestWebConfig(IOptionsSnapshot<WebConfig> optWC)
        {
             this.optWC = optWC;
        }
        public void Test()
        {
            var wc = optWC.Value;
            Console.WriteLine(wc.Conn1.ConnectionString);
            Console.WriteLine(wc.Config.Age);
            Console.WriteLine(wc.Config.Name);
            Console.WriteLine(wc.Config.Proxy.Address);

        }

    }
}
