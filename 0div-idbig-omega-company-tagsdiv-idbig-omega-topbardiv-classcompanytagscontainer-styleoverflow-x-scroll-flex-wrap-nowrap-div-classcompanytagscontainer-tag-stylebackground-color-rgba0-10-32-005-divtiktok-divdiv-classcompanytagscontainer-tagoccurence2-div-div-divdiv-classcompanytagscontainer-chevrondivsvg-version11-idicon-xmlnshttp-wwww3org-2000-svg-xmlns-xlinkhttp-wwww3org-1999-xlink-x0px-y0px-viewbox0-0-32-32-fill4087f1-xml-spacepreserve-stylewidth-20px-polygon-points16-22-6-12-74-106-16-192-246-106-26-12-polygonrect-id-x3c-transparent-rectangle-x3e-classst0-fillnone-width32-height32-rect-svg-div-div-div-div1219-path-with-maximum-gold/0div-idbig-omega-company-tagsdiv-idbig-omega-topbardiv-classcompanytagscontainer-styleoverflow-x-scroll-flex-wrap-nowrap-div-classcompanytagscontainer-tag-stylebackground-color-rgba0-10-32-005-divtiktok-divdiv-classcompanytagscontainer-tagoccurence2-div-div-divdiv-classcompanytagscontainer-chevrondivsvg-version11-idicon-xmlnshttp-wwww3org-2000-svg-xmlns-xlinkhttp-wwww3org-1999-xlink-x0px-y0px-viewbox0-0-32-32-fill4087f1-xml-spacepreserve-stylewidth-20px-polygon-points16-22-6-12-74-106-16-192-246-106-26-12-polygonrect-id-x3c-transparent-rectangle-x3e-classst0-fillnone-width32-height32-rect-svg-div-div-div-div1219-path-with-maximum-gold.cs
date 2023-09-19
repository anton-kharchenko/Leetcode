public class Solution {
    int n = 0;
    int m = 0;
    List<int> result = new List<int>();
    public int GetMaximumGold(int[][] grid) {
        n = grid.Length;
        m = grid[0].Length;
        
        for(var i = 0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(grid[i][j] != 0){
                   result.Add(Dfs(i, j, grid, 0));
                }
            }
        }
        if(!result.Any()) return 0;
        
        return result.Max();
    }
    
    public int Dfs(int i, int j,  int[][] grid, int sum){
        if(i>= n || j>= m || i<0 || j<0 || grid[i][j] == 0){
            return sum;
        }
        
        sum+= grid[i][j];
        var temp = grid[i][j];
        grid[i][j] = 0;
        var top = Dfs(i+1,j, grid, sum);
        var bottom = Dfs(i-1, j, grid, sum);
        var left = Dfs(i, j-1, grid, sum);
        var right = Dfs(i, j+1, grid, sum);
        grid[i][j] = temp;
        
       return Math.Max(Math.Max(top, bottom), Math.Max(left, right));
    }
}