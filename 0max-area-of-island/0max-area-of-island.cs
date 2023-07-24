public class Solution {
    int max = 0;
    
    public int MaxAreaOfIsland(int[][] grid) {
        var set = new HashSet<(int, int)>();
        
        for(var i = 0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(!set.Contains((i, j)) && grid[i][j] == 1){
                    max = Math.Max(Dfs(i, j, grid.Length, grid[0].Length, set, grid), max);
                }
            }
        }
        
        return max;
    }
    
    public int Dfs(int i, int j, int n, int m, HashSet<(int, int)> set, int[][] grid){
        if(i<0|| j<0 || i>=n || j>=m || set.Contains((i, j)) || grid[i][j] != 1){
            return 0;
        }
        set.Add((i, j));
        
        return 1+ Dfs(i+1, j, n, m, set, grid) 
            + Dfs(i-1, j, n, m, set, grid) 
            + Dfs(i, j+1, n, m, set, grid) 
            + Dfs(i, j-1, n, m, set, grid);
    }
}