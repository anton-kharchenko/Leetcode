public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var rows = obstacleGrid.Length;
        var cols = obstacleGrid[0].Length;
        var lookup = new int[rows + 1, cols + 1];

        for (var row = rows - 1; row >= 0; row--)
        {
            for (var col = cols - 1; col >= 0; col--)
            {
                if (row == rows - 1 && col == cols - 1 && obstacleGrid[row][col] != 1)
                {
                    lookup[row, col] = 1;
                }
                else if (obstacleGrid[row][col] == 1)
                {
                    lookup[row, col] = 0;
                }
                else if (row == rows - 1)
                {
                    lookup[row, col] = lookup[row, col + 1];
                }
                else if (col == cols - 1)
                {
                    lookup[row, col] = lookup[row + 1, col];
                }
                else
                {
                    lookup[row, col] = lookup[row + 1, col] + lookup[row, col + 1];
                }
            }
        }

        return lookup[0, 0];
    }   
}