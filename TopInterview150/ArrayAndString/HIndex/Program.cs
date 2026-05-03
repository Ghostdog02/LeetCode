public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [10, 8, 5, 4, 3];

        //SelectSort(numbers);
        Console.WriteLine(FindHIndex(numbers));
    }

    public static int FindHIndex(int[] numbers)
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);

        if (numbers.Length == 1)
        {
            return numbers[0] == 0 ? 0 : 1;
        }

        int hIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > i)
            {
                hIndex++;
            }

            else
            {
                break;
            }
        }

        return hIndex;
    }
}