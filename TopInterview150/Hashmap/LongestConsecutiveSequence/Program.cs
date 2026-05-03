public class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

        System.Console.WriteLine(solution.CalculateLongestSequenceLength(nums));
    }
}

public class Solution
{
    public int CalculateLongestSequenceLength(int[] nums)
    {
        var numSet = new HashSet<int>(nums);
        int maxSequenceLength = 0;
        int currSequenceLength = 1;
        int currNumber;

        foreach (int number in numSet)
        {
            if (!numSet.Contains(number - 1))
            {
                currNumber = number + 1;
                while (numSet.Contains(currNumber))
                {
                    currSequenceLength++;
                    currNumber++;
                }
            }

            maxSequenceLength = Math.Max(maxSequenceLength, currSequenceLength);
            currSequenceLength = 1;
        }

        return maxSequenceLength;
    }
}