public class Program
{
    public static void Main(string[] args)
    {
        int[] heights = [1, 8, 6, 2, 5, 4, 8, 3, 7];

        int left = 0;
        int right = heights.Length - 1;

        int maxArea = int.MinValue;
        int currArea;

        int height;
        int length;

        while (left < right)
        {
            height = Math.Min(heights[left], heights[right]);
            length = Math.Abs(left - right);
            currArea = height * length;

            if (currArea > maxArea)
            {
                maxArea = currArea;
            }

            if (heights[left] < heights[right])
            {
                left++;
            }

            else
            {
                right--;
            }
        }

        System.Console.WriteLine(maxArea);
    }

    public static int CalculateArea(int left, int right, int[] heights)
    {
        int height = Math.Min(heights[left], heights[right]);
        int length = Math.Abs(left - right);

        return height * length;
    }
}