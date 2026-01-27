using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Interface
{
    internal class DerivedMembersAsImplementation
    {
    }
    interface TMove
    {
        void MoveTo();
    }
    class Animal
    {
      public void MoveTo()
        {
            Console.WriteLine("Moving！");
        }
    }
    class Dog:Animal, TMove
    {

    }
}
