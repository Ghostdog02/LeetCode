int[] numbers = [-10, -5, -3, 0, 5, 8];
int target = -8;

int left = 0;
int right = 1;
int currSum;
int end = numbers.Length - 1;

while ((currSum = numbers[left] + numbers[right]) != target)
{
    if (currSum < target)
    {
        if (right < end)
        {
            right++;
        }

        else
        {
            left++;
        }
    }

    else if (currSum > target)
    {
        right--;
        end = right;
        // left++;
    }
}

System.Console.WriteLine($"Left: {left + 1}");
System.Console.WriteLine($"Right: {right + 1}");
