int[] nums = [-1, -100, 3, 99];
int rotateAmount = 2;

int length = nums.Length;
bool[] visited = new bool[length];
int lastrotatedIndex = 0;
int lastReplacedNumber = 0;



for (int counter = 0; counter < length; counter++)
{
    int rotation = lastrotatedIndex + rotateAmount;
    int rotatedIndex = rotation >= length ? rotation % length : rotation;

    while (visited[rotatedIndex])
    {
        lastrotatedIndex++;
        rotation = lastrotatedIndex + rotateAmount;
        rotatedIndex = rotation >= length ? rotation % length : rotation;
        lastReplacedNumber = nums[lastrotatedIndex];
    }

    int temp = nums[rotatedIndex];

    if (counter == 0)
    {
        nums[rotatedIndex] = nums[0];
    }

    else
    {
        nums[rotatedIndex] = lastReplacedNumber;
    }

    visited[rotatedIndex] = true;

    lastrotatedIndex = rotatedIndex;
    lastReplacedNumber = temp;

}

foreach (int number in nums)
{
    System.Console.Write($"{number}, ");
}