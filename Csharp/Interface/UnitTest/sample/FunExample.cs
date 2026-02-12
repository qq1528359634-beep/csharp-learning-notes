using System;
using System.Collections.Generic;
using System.Text;

namespace FunExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeskFan deskFan = new(new PowerSupply());
            deskFan.Work();
            Console.WriteLine(deskFan.Work());
        }
    }
   public interface IPowerSupply
    {
        int GetPower();
    }
    public class PowerSupply : IPowerSupply
    {
        public int GetPower()
        {
            return 210;
        }
    }
    public class DeskFan
    {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "Won't work";
            }
            else if (power < 100)
            {
                return "Work Slow!";
            }
            else if (power < 200)
            {
                return "Work Fine";
            }
            else
            {
                return "Warning";
            }
        }
    }
}
