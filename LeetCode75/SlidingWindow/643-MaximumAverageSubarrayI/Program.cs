namespace _643_MaximumAverageSubarrayI;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = [0,1,1,3,3];
        int k = 4;

        System.Console.WriteLine(FindMaxAverage(nums, k));
    }

    static double FindMaxAverage(int[] nums, int k) {
        double currSum = 0.000000;

        for (int i = 0; i < k; i++)
        {
            currSum += nums[i];
        }

        double maxSum = currSum;

        for (int i = k; i < nums.Length; i++)
        {
            currSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, currSum);
        }

        return (double)maxSum / k;
    }
}
