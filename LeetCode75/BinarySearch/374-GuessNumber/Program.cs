namespace _374_GuessNumber;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(GuessNumber(10));
    }

    static int GuessNumber(int n)
    {
        int left = 1;
        int right = n;
        int mid = 0;

        while (left <= right)
        {
            mid = (right - left) / 2;

            if (guess(mid) == 0)
            {
                return mid;
            }

            else if (guess(mid) == -1)
            {
                right = mid - 1;
            }

            else
            {
                left = mid + 1;
            }
        }
    }
}
