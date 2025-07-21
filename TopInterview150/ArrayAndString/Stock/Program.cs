using System.Globalization;

int[] prices = [7, 1, 5, 3, 6, 4];

int biggestProfit = 0;
int cheapestPrice = prices[0];

for (int i = 0; i < prices.Length; i++)
{
    if (prices[i] < cheapestPrice)
    {
        cheapestPrice = prices[i];
    }

    else if (i != 0)
    {
        int currProfit = prices[i] - cheapestPrice;
        biggestProfit = biggestProfit < currProfit ? currProfit : biggestProfit;
    }
}

System.Console.WriteLine(biggestProfit);