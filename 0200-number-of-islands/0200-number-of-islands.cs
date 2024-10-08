public class Solution {
    public int NumIslands(char[][] grid) {
        var result = 0;
        for(var i = 0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(grid[i][j] == '1'){
                    Dfs(i, j, grid);
                    result += 1;
                }
            }
        }

        return result;
    }

    public void Dfs(int i, int j, char[][] grid){
        if(i>=grid.Length || j>= grid[0].Length || i<0 || j < 0 || grid[i][j] == '0'){
            return;
        }

        grid[i][j] = '0';
        Dfs(i + 1, j, grid);
        Dfs(i - 1, j, grid);
        Dfs(i, j + 1, grid);
        Dfs(i, j - 1, grid);
    }
}