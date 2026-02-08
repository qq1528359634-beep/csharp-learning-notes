using System;
using System.Collections.Generic;
using System.Text;

namespace JasonExample
{
    internal class WebConfig
    {
        public ConnectStr Conn1 { get; set; }
        public ConnectStr ConnTest { get; set; }
        public Config Config { get; set; }
    }
    class ConnectStr
    {

        public string ConnectionString { get; set; }

        public string ProviderName { get; set; }
    }
}
