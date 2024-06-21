public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        var maxSize = 0;
        var lookup = new int[matrix.Length + 1, matrix[0].Length + 1];
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == '1')
                {
                    maxSize = Math.Max(Recurstion(matrix, i, j, lookup), maxSize);
                }
            }
        }

        return maxSize * maxSize;
    }

    public int Recurstion(char[][] matrix, int row, int col, int[,] lookup)
    {
        if (row < 0 || col < 0 || matrix[row][col] == '0')
        {
            return 0;
        }

        if (lookup[row, col] != 0)
        {
            return lookup[row, col];
        }

        lookup[row, col] =  1 + Math.Min(Math.Min(Recurstion(matrix, row - 1, col,lookup), Recurstion(matrix, row, col - 1, lookup)),
                                     Recurstion(matrix, row - 1, col - 1,lookup));

        return lookup[row, col];
    }
}