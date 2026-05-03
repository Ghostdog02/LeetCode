public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7];

        int length = nums.Length;
        int rotateAmount = 3;
        // bound rotateAmount to [0..n-1]
        rotateAmount %= length;

        if (rotateAmount == 0)
            return;

        int lastIndex = 0;
        int lastValue = nums[0];

        int cycles = GetGreatestCommonDivisor(length, rotateAmount);
        int cycleStartIndex = 0;
        int cyclesDone = 0;

        while (cyclesDone < cycles)
        {
            int nextIndex = lastIndex + rotateAmount;

            if (nextIndex >= length)
            {
                nextIndex -= length;
            }

            int temp = nums[nextIndex];

            nums[nextIndex] = lastValue;

            lastIndex = nextIndex;
            lastValue = temp;

            if (cycleStartIndex == nextIndex)
            {
                cyclesDone++;

                if (cyclesDone == cycles)
                {
                    break;
                }

                //Prepare for next cycle
                cycleStartIndex++;
                lastIndex = cycleStartIndex;
                lastValue = nums[lastIndex];
            }
        }

        foreach (int number in nums)
        {
            Console.Write($"{number}, ");
        }
    }
    
    public static int GetGreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return a;
    }
}