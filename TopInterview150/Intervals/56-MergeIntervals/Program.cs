namespace _56_MergeIntervals;

class Program
{
    static void Main(string[] args)
    {
        var result = Merge([[1, 3], [2, 6], [8, 10], [15, 18]]);

        foreach (var nums in result)
        {
            Console.WriteLine(string.Join(',', nums));
        }
    }
    
    static int[][] Merge(int[][] intervals)
    {
        var result = new List<int[]>();
        for (int i = 0; i < intervals.Length; i++)
        {
            for (int j = 0; j < intervals.Length; j++)
            {
                if (j != i)
                {
                    if (intervals[j][0] >= intervals[i][0] && intervals[j][0] <= intervals[i][1] 
                        || intervals[i][0] >= intervals[j][0] && intervals[i][0] <= intervals[j][1])
                    {
                        result.Add([intervals[i][0],  intervals[j][1]]);
                    }
                }
            }
        }

        return result.ToArray();
    }
}