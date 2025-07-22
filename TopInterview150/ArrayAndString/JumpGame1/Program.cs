public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [0, 2, 3];

        System.Console.WriteLine(LinearComplexityApproach(nums));
    }

    public static bool LinearComplexityApproach(int[] nums)
    {
        if (nums.Length == 1)
        {
            return true;
        }

        bool canReachEnd = false;
        int indexToBeSearched = nums.Length - 1;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] + i >= indexToBeSearched)
            {
                if (i == 0)
                {
                    canReachEnd = true;
                }
                
                indexToBeSearched = i;
            }
        }

        return canReachEnd;
    }

    public static bool QuadraticComplexityApproach(int[] nums)
    {
        if (nums.Length == 1)
        {
            return true;
        }

        //Current Index jumped to
        int currJump = nums[0];
        bool[] visited = new bool[nums.Length];

        int allowedTries = nums.Sum();

        for (int i = 0; i < allowedTries; i++)
        {
            if (currJump >= nums.Length - 1)
            {
                return true;
            }

            else if (nums[currJump] == 0 || visited[currJump])
            {
                currJump--;

                if (currJump < 0)
                {
                    return false;
                }
            }

            if (!visited[currJump])
            {
                if (currJump < visited.Length)
                {
                    visited[currJump] = true;
                }

                currJump += nums[currJump];
            }
        }

        return false;
    }
}