using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.LeeCode
{
    internal class RomanToInt
    {
        public int RomanToInt_0(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;

            Dictionary<char, int> romanMap = new() {

              {'I', 1},
              {'V', 5},
              {'X', 10},
              {'L', 50},
              {'C', 100},
              {'D', 500},
              {'M', 1000}
              };



            int totale = 0;
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                int currentVal = romanMap[str[i]];
                if (i < length - 1 && currentVal < romanMap[str[i + 1]])
                {
                    totale -= currentVal;
                }
                else
                {
                    totale += currentVal;
                }
            }
            return totale;
        }


    }

    public class Solution_1
    {
        private int RomanToInt_1(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            int totale = 0;
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                int currentValue = GetValue(str[i]);
                if (i < length - 1 && currentValue < GetValue(str[i + 1]))
                {
                    totale -= currentValue;
                }
                else
                {
                    totale += currentValue;
                }
            }
            return totale;


        }

        private int GetValue(char s)
        {
            switch (s)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }


    }
}


