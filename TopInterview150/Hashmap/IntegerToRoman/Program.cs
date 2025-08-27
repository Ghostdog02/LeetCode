using System.Text;

var romanToIntegerBase = new Dictionary<int, char>()
{
    { 1, 'I' },
    { 5, 'V' },
    { 10, 'X' },
    { 50, 'L' },
    { 100, 'C' },
    { 500, 'D' },
    { 1000, 'M' },
};

var romanToIntegerSubtractions = new Dictionary<int, string>()
{
    { 4, "IV" },
    { 9, "IX" },
    { 40, "XL" },
    { 90, "XC" },
    { 400, "CD" },
    { 900, "CM" },
};

var baseKeys = romanToIntegerBase.Keys.Reverse();
var substractionKeys = romanToIntegerSubtractions.Keys.Reverse();

var result = new StringBuilder();
int input = 1994;
string nums = input.ToString();
int order = (int)Math.Pow(10, nums.Length - 1);
int currDigit;
int addedNumber;

while (input != 0)
{
    nums = input.ToString();
    order = (int)Math.Pow(10, nums.Length - 1);
    currDigit = int.Parse(nums[0].ToString());

    if (currDigit != 4 && currDigit != 9)
    {
        int key = baseKeys.First(number => (input - number) >= 0);
        int occurrences = input / key;

        if (occurrences >= 4)
        {
            key = substractionKeys.First(number => (input - number) >= 0);
            occurrences = input / key;
            addedNumber = currDigit * order;
            result.Append(romanToIntegerSubtractions[addedNumber]);
            
        }

        else
        {
            addedNumber = key * occurrences;
            result.Append(romanToIntegerBase[key], occurrences);
        }
    }

    else
    {
        addedNumber = currDigit * order;
        result.Append(romanToIntegerSubtractions[addedNumber]);
    }

    input -= addedNumber;
    // int firstDigitRemoval = (int)Math.Pow(10, (int)Math.Ceiling(Math.Log10(input)) - 1);
    // input %= firstDigitRemoval;
    // order /= 10;
} 

System.Console.WriteLine(result.ToString());