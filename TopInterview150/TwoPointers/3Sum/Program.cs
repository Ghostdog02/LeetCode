public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [-2, 0, 1, 1, 2];

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
        var triplets = new List<IList<int>>();
        var currentTriplet = new List<int>();

        int numbersLength = numbers.Length;
        int pointer1;
        int pointer2;

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     pointer1 = i + 1;
        //     pointer2 = i + 2;

        //     for (int j = 0; j < numbers.Length / 2 + 1; j++)
        //     {
        //         if (pointer1 == i)
        //         {
        //             pointer1++;
        //         }

        //         if (pointer2 == i)
        //         {
        //             pointer2++;
        //         }

        //         if (pointer1 > numbers.Length - 1)
        //         {
        //             pointer1 -= numbers.Length;
        //         }

        //         if (pointer2 > numbers.Length - 1)
        //         {
        //             pointer2 -= numbers.Length;
        //         }

        //         if (numbers[i] + numbers[pointer1] + numbers[pointer2] == 0)
        //         {
        //             currentTriplet = new List<int> { numbers[i], numbers[pointer1], numbers[pointer2] };
        //             currentTriplet.Sort();
        //             if (!triplets.Any(sequence => sequence.SequenceEqual(currentTriplet)))
        //             {
        //                 triplets.Add(currentTriplet);
        //             }
        //         }

        //         pointer1++;
        //         pointer2++;
        //     }
        // }

        // return triplets;

        for (int i = 0; i < numbersLength; i++)
        {
            for (int j = 0; j < numbersLength; j++)
            {
                for (int k = 0; k < numbersLength; k++)
                {
                    if (numbers[i] + numbers[j] + numbers[k] == 0 && i != k && j != i && j != k)
                    {
                        currentTriplet = new List<int> { numbers[i], numbers[j], numbers[k] };
                        currentTriplet.Sort();
                        if (!triplets.Any(sequence => sequence.SequenceEqual(currentTriplet)))
                        {
                            triplets.Add(currentTriplet);
                        }
                    }
                }
            }
        }

        return triplets;
    }
}