using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace JasonExample
{
    internal class Test2
    {
        private readonly IOptionsSnapshot<Proxy> optProxy;
        public Test2(IOptionsSnapshot<Proxy> optProxy)
        {
            this.optProxy = optProxy;

        }
        public void Test()
        {   Proxy proxy = optProxy.Value;
            Console.WriteLine(proxy.Address);
            Console.WriteLine("******************");
            Console.WriteLine(proxy.Port);
        }
    }
}
