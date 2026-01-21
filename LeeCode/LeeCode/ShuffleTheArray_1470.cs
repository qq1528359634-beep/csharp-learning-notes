using System;
using System.Collections.Generic;
using System.Text;

namespace LeeCode.LeeCode
{
    internal class ShuffleTheArray_1470
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int a = 0;
            int[] nums1 = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                nums1[a++] = nums[i];
                nums1[a++] = nums[i + n];
            }
            return nums1;
        }
    }
}
