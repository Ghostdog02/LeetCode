using System.Buffers;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4, 5];

        Console.WriteLine(LinearApproach(nums));
    }

    public static int LinearApproach(int[] nums)
    {
        int jumpCount = 0;
        int furthestDistance = 0;
        int currEnd = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int reach = i + nums[i];

            if (reach > furthestDistance)
            {
                furthestDistance = reach;
            }

            if (i == currEnd)
            {
                currEnd = furthestDistance;
                jumpCount++;

                if (currEnd >= nums.Length - 1)
                    break;
            }
        }

        return jumpCount;
    }


    public static int QuadraticApproach(int[] nums)
    {
        int jumpCount = 0;
        int currentIndex = 0;
        int currJump = 0;
    
        while (currJump < nums.Length - 1)
        {
            currJump = currentIndex + nums[currentIndex];
            jumpCount++;
    
            if (currJump >= nums.Length - 1)
            {
                return jumpCount;
            }
    
            int idealIndexToJumpFrom = currJump;
    
            for (int i = currJump - 1; i > currentIndex; i--)
            {
                if (i + nums[i] > idealIndexToJumpFrom + nums[idealIndexToJumpFrom])
                {
                    idealIndexToJumpFrom = i;
                }
            }
    
            currentIndex = idealIndexToJumpFrom;
        }
    
        return jumpCount;
    }
}