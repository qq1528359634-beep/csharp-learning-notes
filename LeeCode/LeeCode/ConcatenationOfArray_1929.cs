using System;
using System.Collections.Generic;
using System.Text;

namespace LeeCode.LeeCode
{
    internal class ConcatenationOfArray_1929
    {
        public int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                res[i] = nums[i];
                res[i + n] = nums[i];
            }

            return res;
        }
    }
}
