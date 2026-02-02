using System;
using System.Collections.Generic;
using System.Text;

namespace LogServices
{
    public class ConsoleLogProvider : ILogProvider
    {
        public void LogErroer(string message)
        {
            Console.WriteLine($"Error:{message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Info:{message}");
        }
    }
}
