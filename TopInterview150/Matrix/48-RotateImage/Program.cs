namespace _48_RotateImage;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];

        Rotate(matrix);

        foreach (var row in matrix)
        {
            foreach (var value in row)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }
    }
    
    static void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        for (int layer = 0; layer < n / 2; layer++)
        {
            int first = layer;
            int last = n - 1 - layer;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                int top = matrix[first][i];

                // left → top
                matrix[first][i] = matrix[last - offset][first];
                // bottom → left
                matrix[last - offset][first] = matrix[last][last - offset];
                // right → bottom
                matrix[last][last - offset] = matrix[i][last];
                // top → right
                matrix[i][last] = top;
            }
        }
    }
}