public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        var result = new int[grid.Length - 2][];
        for (var i = 0; i< grid.Length - 2; i++)
        {
            result[i] = new int[grid[0].Length - 2];
        }
        for(var i = 0; i<grid.Length - 2;i++){
            for(var j = 0; j<grid[0].Length - 2;j++){
                result[i][j] =  GetLocalMax(grid, i, j);
            }
        }
        return result;
    }

    private int GetLocalMax(int[][] grid, int row, int col){
        int result = 0;
        for(var i = row; i<row + 3; i++){
            for(var j = col; j<col + 3; j++){
                result = Math.Max(result, grid[i][j]);
            }
        }
        return result;
    }
}