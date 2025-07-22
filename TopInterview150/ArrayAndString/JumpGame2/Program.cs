public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [2, 3, 1, 1, 4];

        int targetIndex = nums.Length - 1;

        int jumpCount = 0;


        for (int i = nums.Length - 2; i >= 0; i--)
        {
            int currFurthestJumpIndex = int.MinValue;
            for (int j = 0; j < nums.Length; j++)
            {
                if (j + nums[j] >= targetIndex)
                {
                    if (currFurthestJumpIndex == int.MinValue ||
                        currFurthestJumpIndex > j)
                    {
                        currFurthestJumpIndex = j;
                    }
                }
            }

            if (currFurthestJumpIndex != targetIndex)
            {
                targetIndex = currFurthestJumpIndex;
                jumpCount++;
                if (targetIndex == 0)
                {
                    break;
                }
            }
        }

        Console.WriteLine(jumpCount);
    }
}