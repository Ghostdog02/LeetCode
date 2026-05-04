namespace _1431_KidsWithTheGreatestNumberOfCandies;

class Program
{
    static void Main(string[] args)
    {
        int[] candies = [2, 3, 5, 1, 3];
        int extraCandies = 3;

        KidsWithCandies(candies, extraCandies);
    }

    static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int max = candies.Max();
        List<bool> result = new List<bool>();

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                result.Add(true);
            }

            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}
