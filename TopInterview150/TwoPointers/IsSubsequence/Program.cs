using System.Globalization;

string input1 = "acb";
string input2 = "ahbgdc";

int pointer1 = 0;
int pointer2 = 0;

if (input1 == string.Empty)
{
    System.Console.WriteLine(true);
}

while (pointer1 < input1.Length && pointer2 < input2.Length)
{
    if (input1[pointer1] == input2[pointer2])
    {
        pointer1++;
    }

    pointer2++;
}

if (pointer1 == input1.Length)
{
    System.Console.WriteLine(true);
}

else
{
    System.Console.WriteLine(false);
}
