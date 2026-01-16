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
        private string _value = "field";
        public string Value
        {
            get
            {

                return _value;
            }
            set
            {
                _value = value;
            }

        }
        public Sample(string value)
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

    #endregion
}

