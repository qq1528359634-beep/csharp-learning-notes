using System;
using System.Collections.Generic;
using System.Text;

namespace LeeCode.LeeCode
{
    internal class _01_Some_Usefu_Tipsl
    {
        static void Main(string[] args)
        {
            #region about char
            char interger = '0';
            //determine whether a char is Digit
            char.IsDigit(interger);  //true
            //between char  0~9 subtract 0 qual that integer number
            var a1 = interger - '0';//0
            interger = '9';
            a1 = interger - '0';//9

            //determine whether a char is  letter
            char letter = 'a';
            char.IsLetter(letter);//true

            //Switch uppercase and  lowercase
            char upper = 'A';
            char lower = 'a';
            char.ToLower(upper); //'a'
            char.ToUpper(lower);//'A'
            #endregion

            #region  about string
            //switch string to integer
            string str = "123";
            //if Parse failed return Exception
            var num = int.Parse(str);
            //if Convert failed return Exception
            num = Convert.ToInt32(str);

            //if TryParse failed return false
            if (int.TryParse(str, out int a))
            {
                num = a;
            }
            #endregion

            #region about Dictionary
            Dictionary<char,int> pairs = new Dictionary<char,int>();
            pairs.Add('a', 1);
            pairs.Contains(new KeyValuePair<char, int>('a',1));
            pairs.ContainsKey('a');//true
            #endregion
        }
    }
}
