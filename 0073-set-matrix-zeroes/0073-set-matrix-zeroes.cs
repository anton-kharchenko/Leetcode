public class Solution {
    int n = 0;
    int m = 0;
    public void SetZeroes(int[][] matrix) {
        var visited = new HashSet<(int, int)>();
        n = matrix.Length;
        m = matrix[0].Length;
        
        for(var i = 0;i<n; i++){
            for(var j = 0;j<m; j++){
                if(!visited.Contains((i, j)) && matrix[i][j] == 0){
                    Dfs(i, j, matrix, visited);
                }
            }
        }
    
    }
    
    public void Dfs(int row, int col, int[][] matrix, HashSet<(int, int)> visited){visited.Add((row, col));
        
        for(var i = 0;i< m; i++ ){
            if( visited.Contains((row, i)) ||  matrix[row][i] == 0) continue;
            matrix[row][i] = 0;
            visited.Add((row, i));
        }
        
        for(var j = 0;j< n; j++ ){
            if( visited.Contains((j, col)) ||  matrix[j][col] == 0) continue;
            matrix[j][col] = 0;
            visited.Add((j, col));
        }
    }
    
}