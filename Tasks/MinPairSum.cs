using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet1
{
    internal class MinPairSumTest
    {
        /*
            //var result = MinPairSum([3, 5, 4, 2, 4, 6]);
            //result = MinPairSum([3, 5, 2, 3]);
            var result = MinPairSum([5, 2, 1, 1, 4, 4, 1, 2, 1, 5]);
         */

        public static int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int result = int.MinValue;

            for (int i = 0; i < n / 2; i++)
            {
                int pairSum = nums[i] + nums[n - i - 1];
                result = Math.Max(result, pairSum);
            }

            return result;

            //var half = nums.Length / 2;
            //Array.Sort(nums);
            //var pairs = new SortedSet<int>();
            //for(var i = 0; i<half; i++)
            //{
            //    pairs.Add(nums[i] + nums[^(i+1)]);
            //}

            //return pairs.Last();
        }
    }
}
