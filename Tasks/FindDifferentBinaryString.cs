using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet1
{
    internal class FindDifferentBinaryStringTest
    {
        /*
           var result = FindDifferentBinaryString(["01", "10"]);
            result = FindDifferentBinaryString(["111", "011", "001"]);
            Console.WriteLine(result);
         */

        public static string FindDifferentBinaryString(string[] nums)
        {
            int length = nums.Length;
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                number.Append(nums[i][i] == '1' ? '0' : '1');
            }
            return number.ToString();

            //HashSet<string> set = new HashSet<string>(nums);
            //int n = nums.Length;
            //char[] result = new char[n];

            //for (int i = 0; i < n; i++)
            //{
            //    result[i] = nums[i][i] == '0' ? '1' : '0';
            //}

            //return new string(result);

            //var length = nums[0].Length;
            //var values = Enumerable.Range(0, byte.MaxValue)
            //    .Select(x=> string.Join("", BitConverter.GetBytes(x).Reverse()
            //    .Select(b => Convert.ToString(b, 2).PadLeft(8, '0'))));
            //values = values.Select(x=>x.Substring(x.Length - length))
            //    .Distinct()
            //    .ToArray();

            //return values.First(q => !nums.Contains(q));
        }
    }
}
