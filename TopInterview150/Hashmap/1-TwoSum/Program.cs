namespace _1_TwoSum;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = TwoSum(new int[] { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 }, 11);

        System.Console.WriteLine( string.Join(", ", arr));
    }

    static int[] TwoSum(int[] nums, int target)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(target - nums[i]))
            {
                return new int[] { i, nums.IndexOf(target - nums[i]) };
            }

            else if (!set.Contains(nums[i]))
            {
                set.Add(nums[i]);
            }
        }

        return new int[] { -1, -1 };
    }
}
