namespace _36_ValidSudoku;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    public bool IsValidSudoku(char[][] board)
    {
        var row = new HashSet<char>();
        var col = new HashSet<char>();
        var subBox = new HashSet<char>();
        
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i][j] != '.')
                {
                    if (!row.Add(board[i][j]))
                    {
                        return false;
                    }
                }

                if (board[j][i] == '.') 
                    continue;
                
                if (!row.Add(board[i][j]))
                {
                    return false;
                }
            }
            
            row.Clear();
            col.Clear();
        }

        for (int rows = 0; rows < UPPER; rows++)
        {
            for (int cols = 0; j < UPPER; j++)
            {
                for (int k = 0; k < UPPER; k++)
                {
                    
                }
            }
        }
        
        return false;
    }
}