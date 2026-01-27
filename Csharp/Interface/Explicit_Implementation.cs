using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{   interface IItf1
    {
        void PrintOut();
    }
    internal class Explicit_Implementation: IItf1
    {    //public is not valid 
         void IItf1.PrintOut()
        {
            Console.WriteLine("IItf1");
        }
        public void Method1()
        {
            // PrintOut(); error
            //this.PrintOut(); error
            IItf1 itf1 = new Explicit_Implementation();
            itf1.PrintOut();
            ((IItf1)this).PrintOut();
            
        }    
    }
}
