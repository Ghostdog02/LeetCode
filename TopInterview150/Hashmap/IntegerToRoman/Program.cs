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

var keys = romanToIntegerBase.Keys;

var result = new StringBuilder();
int input = 3749;
string convertedNum = input.ToString();

// int reversedInput = int.Parse(convertedNum.Reverse().ToString());

int order = 10 ^ (convertedNum.Length - 1);
int currDigit;

while (input != 0)
{
    currDigit = int.Parse(input.ToString()[0].ToString());
    if (currDigit != 4 && currDigit != 9)
    {
        int key = keys.Last(number => (order - number) >= 0);
        int occurrences = order / key;

        if (occurrences > 3)
        {
            
        }

        result.Append(romanToIntegerBase[key], occurrences);
    }

    else
    {
        result.Append(romanToIntegerSubtractions[currDigit * order]);
    }

    //Remove first Digit
    input %= (int)Math.Pow(10, (int)Math.Ceiling(Math.Log10(input)) - 1);
    order /= 10;
}
