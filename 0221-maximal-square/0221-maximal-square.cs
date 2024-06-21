public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        var maxSize = 0;
        var lookup = new int[matrix.Length + 1, matrix[0].Length + 1];
        
        for (int i = 1; i <= matrix.Length; i++)
        {
            for (int j = 1; j <= matrix[0].Length; j++)
            {
                if (matrix[i-1][j-1] == '1')
                {
                    lookup[i, j] = 1 + Math.Min( Math.Min(lookup[i - 1, j], lookup[i, j - 1]), lookup[i-1, j-1]);
                    maxSize = Math.Max(lookup[i, j], maxSize);
                }else if (matrix[i-1][j-1] == '0' || i == matrix.Length || j == matrix.Length)
                {
                    lookup[i, j] = 0;
                }
            }
        }

        return maxSize * maxSize;
    }
}