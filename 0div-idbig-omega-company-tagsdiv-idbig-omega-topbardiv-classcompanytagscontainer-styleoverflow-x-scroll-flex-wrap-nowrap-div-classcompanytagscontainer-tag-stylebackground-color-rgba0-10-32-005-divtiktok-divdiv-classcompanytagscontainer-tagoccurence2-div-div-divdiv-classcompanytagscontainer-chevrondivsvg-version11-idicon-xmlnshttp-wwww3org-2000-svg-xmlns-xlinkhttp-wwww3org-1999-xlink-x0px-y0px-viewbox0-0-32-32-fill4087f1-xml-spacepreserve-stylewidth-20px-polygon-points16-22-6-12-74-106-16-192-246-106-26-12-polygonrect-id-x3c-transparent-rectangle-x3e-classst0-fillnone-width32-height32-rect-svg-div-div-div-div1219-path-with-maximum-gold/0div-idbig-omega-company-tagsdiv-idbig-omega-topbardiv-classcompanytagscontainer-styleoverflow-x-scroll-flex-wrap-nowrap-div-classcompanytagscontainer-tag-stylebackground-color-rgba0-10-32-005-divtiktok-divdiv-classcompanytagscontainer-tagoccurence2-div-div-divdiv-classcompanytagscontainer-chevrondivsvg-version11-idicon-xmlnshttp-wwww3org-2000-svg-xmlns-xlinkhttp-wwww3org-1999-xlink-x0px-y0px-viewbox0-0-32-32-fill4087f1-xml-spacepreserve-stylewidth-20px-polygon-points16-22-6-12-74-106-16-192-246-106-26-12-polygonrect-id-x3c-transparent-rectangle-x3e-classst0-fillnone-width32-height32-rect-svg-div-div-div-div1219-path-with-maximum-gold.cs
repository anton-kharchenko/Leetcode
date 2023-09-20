public class Solution {
    int n = 0;
    int m = 0;
    List<int> results = new List<int>();
    public int GetMaximumGold(int[][] grid) {
        n = grid.Length;
        m = grid[0].Length;
        
        for(var i = 0; i< n; i++){
            for(var j = 0; j<m; j++){
                if(grid[i][j] != 0){
                    results.Add(Dfs(i, j, grid, 0));
                }
            }
        }
        
        if(!results.Any()) return 0;
        return results.Max();
    }
    
    public int Dfs(int i, int j, int[][] grid, int sum){
        if(i <0 || j< 0 || i>= n || j>=m || grid[i][j] == 0){
            return sum;
        }
        
        sum += grid[i][j];
        var temp = grid[i][j];
        grid[i][j] = 0;
        
        var left = Dfs(i, j-1, grid, sum);
        var right = Dfs(i, j+1, grid, sum);
        var top = Dfs(i+1, j, grid, sum);
        var bottom = Dfs(i-1, j, grid, sum);
        
        grid[i][j] = temp;
        
        return Math.Max(Math.Max(left, right), Math.Max(top, bottom));
    }
    
}