using System.Text;

namespace _345_ReverseVowelsString;

class Program
{
    static void Main(string[] args)
    {
        string s = "leetcode";
        Console.WriteLine(ReverseVowels(s));
    }

    static string ReverseVowels(string s) {
        var vowels = new List<char>
        {
           'a', 'e', 'i', 'o', 'u',
           'A', 'E', 'I', 'O', 'U'  
        };
        var builder = new StringBuilder();

        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        while (leftPointer < s.Length)
        {
            if (vowels.Contains(s[leftPointer]))
            {
                while (!vowels.Contains(s[rightPointer]))
                {
                    rightPointer--;
                }

                builder.Append(s[rightPointer]);
                rightPointer--;
            }

            else
            {
                builder.Append(s[leftPointer]);
            }

            leftPointer++;
        }

        return builder.ToString();
    }
}
