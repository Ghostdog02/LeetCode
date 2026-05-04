using System.Text;

namespace _1768_MergeStringsAlternately;

class Program
{
    static void Main(string[] args)
    {
        string word1 = "ab";
        string word2 = "pqrs";

        System.Console.WriteLine(MergeAlternately(word1, word2));
    }

    static string MergeAlternately(string word1, string word2)
    {
        var builder = new StringBuilder();
        int i = 0;

        while (i < word1.Length || i < word2.Length)
        {
            if (i < word1.Length)
            {
                builder.Append(word1[i]);
            }

            if (i < word2.Length)
            {
                builder.Append(word2[i]);
            }

            i++;
        }

        return builder.ToString();
    }
}
