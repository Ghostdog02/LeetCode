namespace _54_SpiralMatrix;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];

        foreach (var value in SpiralOrder(matrix))
            Console.Write($"{value} ");
    }

    static IList<int> SpiralOrder(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        var result = new List<int>(rows * cols);

        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;

        while (top <= bottom && left <= right)
        {
            for (int col = left; col <= right; col++)
                result.Add(matrix[top][col]);
            top++;

            for (int row = top; row <= bottom; row++)
                result.Add(matrix[row][right]);
            right--;

            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    result.Add(matrix[bottom][col]);
                bottom--;
            }

            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    result.Add(matrix[row][left]);
                left++;
            }
        }

        return result;
    }
}