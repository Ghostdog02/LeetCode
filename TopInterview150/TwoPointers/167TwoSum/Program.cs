int[] numbers = [-10, -5, -3, 0, 5, 8];
int target = -8;

int left = 0;
int right = numbers.Length - 1;
int currSum;

while ((currSum = numbers[left] + numbers[right]) != target)
{
    if (currSum < target)
    {
        left++;
    }

    else if (currSum > target)
    {
        right--;
    }
}

System.Console.WriteLine($"Left: {left + 1}");
System.Console.WriteLine($"Right: {right + 1}");
