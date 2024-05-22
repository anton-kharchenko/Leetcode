public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int result = 0;
        for(int i = 0; i<rows; i++){
            for(int j = 0; j< cols; j++){
                if(grid[i][j] == '1'){
                    RemoveIsland(grid, i, j, rows, cols);
                    result += 1;
                }
            }
        }
        return result;
    }


    public void RemoveIsland(char[][] grid, int row, int col, int rows, int cols){
        if(row<0 || col<0 || row>= rows || col>= cols || grid[row][col] == '0'){
            return;
        }
        grid[row][col] = '0';
        RemoveIsland(grid, row + 1, col, rows, cols);
        RemoveIsland(grid, row - 1, col, rows, cols);
        RemoveIsland(grid, row, col + 1, rows, cols);
        RemoveIsland(grid, row, col - 1, rows, cols);
    }

}