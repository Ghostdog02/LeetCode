public class Program
{
    

    public static void Main(string[] args)
    {
        var solution = new Solution();
        int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

        System.Console.WriteLine(solution.CalculateLongestSequenceLength(nums));
    }
}

public class Solution
{
    public int CurrNumber { get; set; }

    public int SequenceLength { get; set; }

    public Dictionary<int, List<int>> Sequences { get; set; }

    public int LongestSequenceLength { get; set; }

    public Dictionary<int, bool> VisitedNumbers { get; set; }

    public Solution()
    {
        SequenceLength = 1;
        Sequences = new Dictionary<int, List<int>>();
        VisitedNumbers = new Dictionary<int, bool>();
    }

    public int CalculateLongestSequenceLength(int[] nums)
    {
        foreach (int currNumber in nums)
        {
            if (!Sequences.TryGetValue(currNumber, out _))
            {
                Sequences.Add(currNumber, new List<int>());
            }
        }

        foreach (var keyValuePair in Sequences)
        {
            int key = keyValuePair.Key;

            if (!VisitedNumbers.TryGetValue(key, out _))
            {
                bool hasNext = Sequences.TryGetValue(key + 1, out _);
                bool hasPrev = Sequences.TryGetValue(key - 1, out _);
                if (hasNext && hasPrev)
                {
                    IterateSequence(key, false);
                    IterateSequence(key, true);
                }
                else if (hasNext)
                {
                    IterateSequence(key, true);
                }
                else if (hasPrev)
                {
                    IterateSequence(key, false);
                }
                else
                {
                    VisitedNumbers.Add(key, true);
                }

                if (SequenceLength > LongestSequenceLength)
                {
                    LongestSequenceLength = SequenceLength;
                }

                CurrNumber = 0;
                SequenceLength = 1;
            }
        }

        return LongestSequenceLength;
    }

    public void IterateSequence(int key, bool isIncrementing)
    {
        switch (isIncrementing)
        {
            case true:
                CurrNumber = key + 1;
                break;
            case false:
                CurrNumber = key - 1;
                break;
        }

        while (Sequences.TryGetValue(CurrNumber, out _))
        {
            VisitedNumbers.Add(CurrNumber, true);
            Sequences[key].Add(CurrNumber);
            SequenceLength++;
            switch (isIncrementing)
            {
                case true:
                    CurrNumber++;
                    break;
                case false:
                    CurrNumber--;
                    break;
            }
        }
    }
}