using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    public interface IInt1
    {
          void  PrintOut();
    }
    public interface IInt2
    {
         void  PrintOut();
    }

     class InterfaceDuplicateMembers: IInt1, IInt2
    {
       public  void PrintOut()
        {
            Console.WriteLine("printed !");
        }
    }
}
