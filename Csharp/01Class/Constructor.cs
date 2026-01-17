using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp._01Class
{

    #region コンストラクターのオーバーロード
    internal class Constructor
    {
        public string lastName;//フィールド普通はプライベートで修飾
        public string firtsName;

        //引数がない場合　オーバーロードでもう一つのコンストラクターを呼び出します
        public Constructor() : this("niro", "sanro") { }

        public Constructor(string lastName, string firstName)
        {
            this.lastName = lastName;
            firtsName = firstName;
        }
        public void PrintName()
        {
            Console.WriteLine($"My name is {this.lastName} {this.firtsName}");
        }
    }
    #endregion

    #region イニシャライズ　
    class initializer_
    {

        static void Main(string[] args)
        {
            Constructor person = new Constructor();
            person.PrintName();
            // オブジェクト初期化
            Constructor person1 = new Constructor
            {
                firtsName = "chen",
                lastName="hanqing"

            };
            person1.PrintName();

          
        }
    }
    #endregion

    #region クラス中の値の与え順番
    
    class Sample
    {
        private string _value = "field";//frist
        public string Value
        {
            get
            {

                return _value;
            }
            set
            {   
                _value = value;//third
            }

        }
        public Sample(string value)//second
        {
            Print();
            this._value = value;
            Print();
        }
        public void Print()
        {
            Console.WriteLine(_value);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Sample sa = new Sample("Constructor")
            {
                Value = "initializer"
            };
            sa.Print();
            //field
            //constructor
            //initializer
        }
    }
    /*class Program1
    {
        private string _value = "field";
        private bool _count = true;

        public string Value
        {
            get
            {

                return _value;
            }

            set
            {
                if (_count)
                {
                    Print(_value);
                    _count = false;
                }
                ;

                _value = value;
            }
        }

        public Program1(string value)
        {

            this.Value = value;
            Print(Value);

        }
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            Program1 sequence = new Program1("constructor")
            {
                Value = "initializer",

            };

            sequence.Print(sequence.Value);
            //field
            //constructor
            //initializer
        }
    }

}*/
    #endregion
}

