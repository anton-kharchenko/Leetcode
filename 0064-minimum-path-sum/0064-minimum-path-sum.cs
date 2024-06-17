public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        for (var i = grid.Length - 1; i>=0; i--)
        {
            for (int j = grid[0].Length - 1; j >= 0; j--)
            {
                if (i == grid.Length - 1 && j != grid[0].Length - 1)
                {
                    grid[i][j] += grid[i][j + 1];
                }else if(i != grid.Length - 1 && j == grid[0].Length - 1){
                    grid[i][j] += grid[i + 1][j];
                }else if(i != grid.Length - 1 && j != grid[0].Length - 1){
                    grid[i][j] += Math.Min(grid[i + 1][j], grid[i][j+1]);
                }
            }
        }
        
        return grid[0][0];
    }
}