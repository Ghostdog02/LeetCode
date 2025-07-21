namespace Stock2;

public class Program
{
    static void Main(string[] args)
    {
        int[] prices = [7, 6, 4, 3, 1];

        int profit = 0;

        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1])
            {
                profit += prices[i + 1] - prices[i];
            }
        }

        System.Console.WriteLine(profit);
    }
}
