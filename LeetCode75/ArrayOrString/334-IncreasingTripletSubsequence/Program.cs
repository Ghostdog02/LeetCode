namespace _334_IncreasingTripletSubsequence;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IncreasingTriplet([1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]));
    }
    
    static bool IncreasingTriplet(int[] nums)
    {
        int numsLength = nums.Length;
        
        if (numsLength < 3)
            return false;
        int min1 = int.MaxValue, min2 = int.MaxValue;
        
        for (int i = 0; i < numsLength; i++)
        {
            int x = nums[i];
            
            if(x <= min1)
            {
                min1 = x;
            } 
            
            else if(x <= min2)
            {
                min2 = x;
            }
            
            else
            {
                return true;
            }        
        }
        
        return false;
    }
}