using System.Text;

var values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

var result = new StringBuilder();
int input = 3749;
//string nums = input.ToString();

// while (input != 0)
// {
//     int key = baseKeys.First(number => (input - number) >= 0);
//     int occurrences = input / key;

//     for (int i = 0; i < occurrences; i++)
//     {
//         result.Append(romanToIntegerBase[key]);
//     }

//     input -= (key * occurrences);
// }

for (int i = 0; i < values.Length; i++)
{
        int occurrences = input / values[i];

        for (int j = 0; j < occurrences; j++)
        {
            result.Append(symbols[i]);
        }

        input %= values[i];
}

// foreach (int key in baseKeys)
// {
//     int occurrences = input / key;
//     if (occurrences > 0)
//     {
//         for (int i = 0; i < occurrences; i++)
//         {
//             result.Append(romanToIntegerBase[key]);
//         }

//         input -= (key * occurrences);
//     }
// }

System.Console.WriteLine(result.ToString());