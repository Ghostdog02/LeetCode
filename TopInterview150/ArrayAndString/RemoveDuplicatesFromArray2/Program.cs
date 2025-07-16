public class Program
{
    public static void Main(string[] args)
    {
        LinearTimeApproach();
    }

    public static int LinearTimeApproach()
    {
        int[] nums = [1, 2, 2];

        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        int writeIndex = 2;

        for (int readIndex = 2; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] != nums[writeIndex - 2])
            {
                nums[writeIndex++] = nums[readIndex];
            }
        }

        return writeIndex;
    }

    public static void QuadraticRuntimeApproach()
    {
        int[] nums = [0, 0, 1, 1, 1, 1, 2, 2, 2, 4];

        int pointer = 0;
        int end = nums.Length;

        //If counter = 2 it means there are three ocurrences of a number
        int duplcateCounter = 0;

        for (int i = 1; i < end; i++)
        {
            if (nums[pointer] == nums[i])
            {
                duplcateCounter++;
            }

            if (duplcateCounter == 2)
            {
                int lastPointerValue = nums[pointer];
                int currentValue = 0;

                do
                {
                    int tempIndex = i;
                    lastPointerValue = nums[pointer];
                    while (tempIndex < end - 1)
                    {
                        nums[tempIndex] = nums[tempIndex + 1];
                        tempIndex++;
                    }

                    nums[tempIndex] = 0;

                    if (end == i)
                    {
                        break;
                    }

                    end--;
                    duplcateCounter--;

                    pointer = i - 1;

                    currentValue = nums[i];
                } while (lastPointerValue == currentValue);
            }

            if (nums[pointer] != nums[i])
            {
                pointer = i;
                duplcateCounter = 0;
            }
        }

        foreach (int num in nums)
        {
            Console.Write($"{num}, ");
        }

        Console.WriteLine($"UniquePairs: {end}");
    }
}
