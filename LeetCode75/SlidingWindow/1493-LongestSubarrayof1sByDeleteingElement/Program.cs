namespace _1493_LongestSubarrayof1sByDeleteingElement;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(LongestSubarray([0,1,1,1,0,1,1,0,1]));
    }

    static int LongestSubarray(int[] nums) {
        int left = 0;
        int zeroCounter = 0;
        int maxCounter = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                while (zeroCounter >= 1)
                {
                    if (nums[left] == 0)
                    {
                        zeroCounter--;
                    }

                    left++;
                }

                zeroCounter++;
            }

            maxCounter = Math.Max(maxCounter, right - left);
        }   

        return maxCounter;  
    }
}
