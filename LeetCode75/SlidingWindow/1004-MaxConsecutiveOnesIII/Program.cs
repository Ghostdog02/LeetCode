namespace _1004_MaxConsecutiveOnesIII;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = [0,0,0,1];
        int k = 4;
        Console.WriteLine(LongestOnes(nums, k));
    }

    static int LongestOnes(int[] nums, int k)
    {
        int zeroesCount = 0;
        int left = 0;
        int max = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                while (zeroesCount >= k)
                {
                    if (nums[left] == 0)
                    {
                        zeroesCount--;
                    }

                    left++;
                }
            }

            max = Math.Max(max, right - left + 1);
        }

        return max;
    }
}
