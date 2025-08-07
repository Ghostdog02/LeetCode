using System.Text;

string s = " ";

bool isPalindrome = true;

int left = 0;
int right = s.Length - 1;

while (left < right)
{
    bool isLeftInvalid = !char.IsAsciiLetterOrDigit(s[left]);
    bool isRightInvalid = !char.IsAsciiLetterOrDigit(s[right]);

    if (isLeftInvalid)
    {
        left++;
    }

    if (isRightInvalid)
    {
        right--;
    }

    if (isLeftInvalid || isRightInvalid)
    {
        continue;
    }

    if (char.ToLower(s[left]) != char.ToLower(s[right]))
    {
        isPalindrome = false;
        break;
    }

    left++;
    right--;
}

System.Console.WriteLine(isPalindrome);