using System.Text;

namespace _1071_GreatestCommonDivisorStrings;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "AABBAABBAA";
        string str2 = "AABB";
        GcdOfStrings(str1, str2);
    }

    static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }

        return str1.Substring(0, GCDOfLength(str1.Length, str2.Length));
    }

    static int GCDOfLength(int len1, int len2)
    {
        while (len2 != 0)
        {
            int temp = len2;
            len2 = len1 % len2;
            len1 = temp;
        }

        return len1;
    }
}
