namespace RemoveDuplicatesFromArray1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [0, 0, 1, 1, 1, 2, 2];
        Console.WriteLine(RemoveDuplicates1(nums));
    }

    public static int RemoveDuplicates1(int[] nums)
    {
        int pointer = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[pointer])
            {
                nums[++pointer] = nums[i];
            }
        }

        return pointer + 1;
    }
}
