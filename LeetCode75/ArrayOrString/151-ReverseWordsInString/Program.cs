using System.Text;

namespace _151_ReverseWordsInString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseWords("  hello world  "));
    }
    
    static string ReverseWords(string s)
    {
        var builder = new StringBuilder();

        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return string.Join(' ', words);
    }
}