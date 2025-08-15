public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [-1, 0, 1, 2, -1, -4];

        var program = new Program();
        var triplets = program.FindTriplets(numbers);

        foreach (List<int> triplet in triplets)
        {
            foreach (int num in triplet)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();
        }
    }

    public IList<IList<int>> FindTriplets(int[] numbers)
    {
        Array.Sort(numbers);

        //var triplets = new HashSet<IList<int>>();

        var triplets = new List<IList<int>>();
        var currentTriplet = new List<int>();

        int numbersLength = numbers.Length;
        int left = 0;
        int right = 0;
        int targetSum = 0;

        for (int currIndex = 0; currIndex < numbers.Length - 2; currIndex++)
        {
            targetSum = -numbers[currIndex];
            left = currIndex + 1;
            right = numbersLength - 1;

            if (currIndex > 0 && numbers[currIndex] == numbers[currIndex - 1])
                continue;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == targetSum)
                {
                    currentTriplet = [numbers[currIndex], numbers[left], numbers[right]];

                    triplets.Add(currentTriplet);

                    int leftVal = numbers[left];
                    while (left < right && numbers[left] == leftVal)
                        left++;

                    int rightVal = numbers[right];
                    while (left < right && numbers[right] == rightVal)
                        right--;
                }

                else if (sum > targetSum)
                {
                    right--;
                }

                else
                {
                    left++;
                }
            }
        }

        return triplets.ToList();
    }
}
