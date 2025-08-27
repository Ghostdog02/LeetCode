using System.Text;

var romanToIntegerBase = new Dictionary<int, string>()
{
    { 1, "I" },
    { 4, "IV" },
    { 5, "V" },
    { 9, "IX" },
    { 10, "X" },
    { 40, "XL" },
    { 50, "L" },
    { 90, "XC" },
    { 100, "C" },
    { 400, "CD" },
    { 500, "D" },
    { 900, "CM" },
    { 1000, "M" },
};

// var romanToIntegerSubtractions = new Dictionary<int, string>()
// {
//     { 4, "IV" },
//     { 9, "IX" },
//     { 40, "XL" },
//     { 90, "XC" },
//     { 400, "CD" },
//     { 900, "CM" },
// };

var baseKeys = romanToIntegerBase.Keys.Reverse();
// var substractionKeys = romanToIntegerSubtractions.Keys.Reverse();

    var result = new StringBuilder();
    int input = 3749;
    string nums = input.ToString();

// while (input != 0)
// {
//     nums = input.ToString();
//     order = (int)Math.Pow(10, nums.Length - 1);
//     currDigit = int.Parse(nums[0].ToString());

//     if (currDigit != 4 && currDigit != 9)
//     {
//         int key = baseKeys.First(number => (input - number) >= 0);
//         int occurrences = input / key;

//         if (occurrences >= 4)
//         {
//             key = substractionKeys.First(number => (input - number) >= 0);
//             occurrences = input / key;
//             addedNumber = currDigit * order;
//             result.Append(romanToIntegerSubtractions[addedNumber]);

//         }

//         else
//         {
//             addedNumber = key * occurrences;
//             result.Append(romanToIntegerBase[key], occurrences);
//         }
//     }

//     else
//     {
//         addedNumber = currDigit * order;
//         result.Append(romanToIntegerSubtractions[addedNumber]);
//     }

//     input -= addedNumber;
//     // int firstDigitRemoval = (int)Math.Pow(10, (int)Math.Ceiling(Math.Log10(input)) - 1);
//     // input %= firstDigitRemoval;
//     // order /= 10;
// } 

while (input != 0)
{
    int key = baseKeys.First(number => (input - number) >= 0);
    int occurrences = input / key;

    for (int i = 0; i < occurrences; i++)
    {
        result.Append(romanToIntegerBase[key]);
    }

    input -= (key * occurrences);
}

System.Console.WriteLine(result.ToString());