using System.Globalization;

namespace _1456_MaximumVowelsInSubstring;

class Program
{
    public int MaxVowelsCount = 0;

    static void Main(string[] args)
    {
        string s = "weallloveyou";
        int k = 7;
        System.Console.WriteLine(MaxVowels(s, k));
    }

    static int MaxVowels(string s, int k) {
        var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        int countVowels = 0;
        int maxVowelsCount = 0;
        int count = 0;
        int left = 0;
        int right = 0;

        while (right < s.Length)
        {
            if (vowels.Contains(s[right]))
            {
                countVowels++;
            }
            
            right++;
            count++;

            if (count == k)
            {
                maxVowelsCount = maxVowelsCount < countVowels ? countVowels : maxVowelsCount;
                if (vowels.Contains(s[left]))
                {
                    countVowels--;
                }
                
                left++;
                count--;
            }
        }

        return maxVowelsCount;
    }
}
