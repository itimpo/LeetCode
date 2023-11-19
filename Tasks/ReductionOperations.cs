namespace LeetCode.Tasks
{
    internal class ReductionOperationsTest
    {
        public static int ReductionOperations(int[] nums)
        {
            var changes = 0;
            Array.Sort(nums);
            Array.Reverse(nums);
            var max = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    continue;
                }
                if (nums[i] < max)
                {
                    max = nums[i];
                    changes += i;
                }
            }
            return changes;
        }
    }
}
