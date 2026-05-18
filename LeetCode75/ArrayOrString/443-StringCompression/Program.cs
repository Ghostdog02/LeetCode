using System.Text;

namespace _443_StringCompression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Compress(['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']));
    }
    
    static int Compress(char[] chars)
    {
        int index = 0;
        int i = 0;

        while (i < chars.Length)
        {
            char current = chars[i];
            int count = 0;

            while (i < chars.Length && chars[i] == current)
            {
                i++;
                count++;
            }

            chars[index++] = current;

            if (count > 1)
            {
                foreach (char c in count.ToString())
                    chars[index++] = c;
            }
        }

        return index;
    }
}