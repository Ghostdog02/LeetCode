using System.Collections;
using System.Text.RegularExpressions;

namespace _71_SimplifyPath;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(SimplifyPath(@"/home/foo/.ssh/../.ssh2/authorized_keys/"));
    }

    static string SimplifyPath(string path) {
        string[] splitInput = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var stack = new Stack<string>();
        int skip = 0;

        for (int i = splitInput.Length - 1; i >= 0; i--)
        {
            if (splitInput[i] == ".")
            {
                continue;
            }

            else if (splitInput[i] == "..")
            {
               skip++; 
            }

            else if (skip == 0)
            {
                stack.Push("/" + splitInput[i]);
            }

            else
            {
                skip--;
            }
        }

        return stack.Count > 0 ? string.Join("", stack) : "/";
    }
}
