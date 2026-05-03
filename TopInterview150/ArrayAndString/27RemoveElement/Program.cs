namespace _27RemoveElement;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        int val = 2;
        Console.WriteLine(RemoveElement(nums, val));
    }

    public static int RemoveElement(int[] nums, int val)
    {
        //It moves when a non val element is found 
        int pointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                if (pointer != i)
                {
                    nums[pointer] = nums[i];
                }

                pointer++;
            }
        }

        return pointer;
    }

    public static int RemoveElementTwoPointersApproach(int[] nums, int val)
    {
        int left = 0;
        int right = 0;

        while (left <= right)
        {
            if (nums[left] == val)
            {
                nums[left] = nums[right];
                right--;
            }

            else
            {
                left++;
            }
        }

        return left;
    }
}
