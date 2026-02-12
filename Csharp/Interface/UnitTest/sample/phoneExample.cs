using System;
using System.Collections.Generic;
using System.Text;

namespace phoneExample
{
    internal class Program
    {
         void Main(string[] args)
        {  
            
            Iphone iphone = new NokiaPhone();
            PhoneUser phoneUser = new(new NokiaPhone());
            phoneUser.UsePhone();
        }
    }
    class PhoneUser
    {
        private Iphone _Iphone;
        public PhoneUser(Iphone iphone)
        {
            _Iphone = iphone;
        }
        public void UsePhone()
        {
            _Iphone.Send();
            _Iphone.Receive();
            _Iphone.PickUp();
            _Iphone.Dial();

        }
    }
    interface Iphone
    {
        void Dial();
        void PickUp();
        void Send();
        void Receive();
    }
    class NokiaPhone : Iphone
    {
        public void Dial()
        {
            Console.WriteLine("Nokia Calling");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello this is Cks");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Hello！");
        }
    }
    class SamPhone : Iphone
    {
        public void Dial()
        {
            Console.WriteLine("SamPhone Calling");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello this is Cks");
        }

        public void Receive()
        {
            Console.WriteLine("SamPhone message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Hello！");
        }
    }
}
 