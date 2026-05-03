public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [2, 9, 0, 1, 1, 1, 1];
        Console.WriteLine(FindMajorityElement(nums));
    }

    public static int FindMajorityElement(int[] nums)
    {
        int votes = 0;
        int candidate = -1;

        for (int index = 0; index < nums.Length; index++)
        {
            if (votes == 0)
            {
                candidate = nums[index];
                votes = 1;
            }

            else if (nums[index] == candidate)
            {
                votes++;
            }

            else
            {
                votes--;
            }
        }

        int count = 0;
        for (int index = 0; index < nums.Length; index++)
        {
            if (nums[index] == candidate)
            {
                count++;
            }

            if (count > nums.Length / 2)
            {
                return candidate;
            }
        }

        return -1;
    }
}