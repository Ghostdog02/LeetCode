namespace _1_TwoSum;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = TwoSum(new int[] { 3, 2, 4 }, 6);

        System.Console.WriteLine( string.Join(", ", arr));
    }

    static int[] TwoSum(int[] nums, int target)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(target - nums[i]))
            {
                
            }
        }

        return new int[] { };
    }
}
