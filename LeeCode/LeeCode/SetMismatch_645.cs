using System;
using System.Collections.Generic;
using System.Text;

namespace LeeCode.LeeCode
{
    internal class SetMismatch_645
    {    
        public static int[] FindErrorNums(int[] nums)
        {   int n=nums.Length;
            int repetition=-1;  
            int lossNumber=-1;  
            int [] result = new int[n+1];
            foreach (var item in nums)
            {
                result[item]++;
            }
            for (int i = 1;i < n+1; i++)
            {
                if (result[i] == 0)
                {
                    lossNumber=i;
                }
                else if (result[i] == 2)
                {
                    repetition=i;   
                }
            }
            return new int[] { repetition, lossNumber };
        }
       
    }
}
