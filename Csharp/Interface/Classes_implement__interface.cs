using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;

namespace Csharp.Interface
{
    internal class Classes_implement__interface
    {
        static void Main(string[] args)
        {
            Animals[] animals = new Animals[3];
            animals[0]=new Cats("kitten");
            animals[1]=new Dogs("puppy");
            animals[2]=new Birds("？？？");
            foreach(var animal in animals)
            {
                IBabyCall babyCall= animal as IBabyCall;
                if (babyCall!=null)
                {
                    babyCall.Call();
                }
            }
        }
    }
    interface IBabyCall
    {
     public   void Call();
    }
    class Animals
    {
        protected string BabyCalled { get; set; }

        public Animals(string a)
        {
            BabyCalled = a;
        }
    }
    class Cats : Animals, IBabyCall 
    {    public Cats(string a) : base(a) { }
         void IBabyCall.Call()
        {
            Console.WriteLine($"{this.BabyCalled}");
        }
    }
    class Dogs : Animals,IBabyCall
    {
        public Dogs(string a) : base(a) { }
         void IBabyCall.Call()
        {
            Console.WriteLine($"{this.BabyCalled}");
        }

    }
    class Birds : Animals
    {
        public Birds(string a) : base(a) { }
    }
    
}
