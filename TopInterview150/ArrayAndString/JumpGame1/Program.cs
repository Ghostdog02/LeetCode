public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0];

        if (nums.Length == 1)
        {
            return;
        }

        int currJump = nums[0];
        bool[] visited = new bool[nums.Length];

        int allowedTries = nums.Sum();

        for (int i = 0; i < allowedTries; i++)
        {
            if (currJump >= nums.Length - 1)
            {
                System.Console.WriteLine(true);
                return;
            }

            else if (nums[currJump] == 0 || visited[currJump])
            {
                currJump--;

                if (currJump < 0)
                {
                    System.Console.WriteLine("false");
                    return;
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

        System.Console.WriteLine("false");
    }
}