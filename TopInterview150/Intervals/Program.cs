namespace _228_SummaryRanges;

class Program
{
    static void Main(string[] args)
    {
        var list = SummaryRanges([0, 1, 2, 4, 5, 7]);

        foreach (var range in list)
        {
            Console.WriteLine(range);
        }
    }
    
    static IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
        {
            return new List<string>();
        }
        
        var result = new List<string>();
        int lastNumIndex = 0;
        int firstRangeIndex = 0;
        
        for (int i = 1; i <= nums.Length; i++)
        {
            if (nums.Length == i || nums[lastNumIndex] != nums[i] - 1)
            {
                if (firstRangeIndex != lastNumIndex)
                {
                    result.Add($"{nums[firstRangeIndex]}->{nums[lastNumIndex]}");
                }

                else
                {
                    result.Add($"{nums[firstRangeIndex]}");    
                }
                
                firstRangeIndex = i;
            }

            lastNumIndex = i;
        }
        
        return result;
    }
}