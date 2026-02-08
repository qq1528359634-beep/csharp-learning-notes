using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    internal class Use_Interface_asParameter
    {
        interface IPrinter
        {
            string GetName();
            string GetAge();
        }


        class Printer : IPrinter
        {
            public int Age { get; set; }

            public string Name { get; set; }

            public string GetName()
            {
                return Name;
            }
            public string GetAge()
            {
                return Age.ToString();
            }
            class Printer1 : IPrinter
            {
                public int Age { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }

                public string GetAge()
                {
                    return Age.ToString();
                }
                public string GetName()
                {
                    return FirstName + " " + LastName;
                }
            }

            internal class Classes_implement__interface
            {
                static void PrintPrinterInfo(IPrinter Iprinter)
                {
                    Console.WriteLine($"Name: {Iprinter.GetName()}, Age: {Iprinter.GetAge()}");
                }
                static void Main(string[] args)
                {


                    Printer printer = new Printer()
                    {
                        Name = "Printer",
                        Age = 10
                    };
                    Printer1 printer1 = new Printer1()
                    {
                        FirstName = "Printer",
                        LastName = "One",
                        Age = 5
                    };
                    PrintPrinterInfo(printer);
                    PrintPrinterInfo(printer1);

                }

            }
        }
    }
}
