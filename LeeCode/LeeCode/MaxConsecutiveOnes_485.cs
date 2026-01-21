using System;
using System.Collections.Generic;
using System.Text;

namespace LeeCode.LeeCode
{
    internal class MaxConsecutiveOnes_485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = nums[i] == 1 ? count + 1 : 0;
                res = count > res ? count : res;
            }
            return res;

        }
    }
}
