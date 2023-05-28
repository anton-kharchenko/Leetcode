public class Solution {
    public void SetZeroes(int[][] matrix) {
        var visited = new List<List<bool>>();

        for (var i =0; i<matrix.Length; i++)
        {
            visited.Add(new List<bool>());
            for (var j = 0; j < matrix[0].Length; j++)
            {
                visited[i].Add(false);
            }
        }
        
        for(var i =0; i<matrix.Length; i++){
            for(var j = 0; j<matrix[0].Length; j++){
                if(!visited[i][j] && matrix[i][j] == 0)
                    Dfs( matrix, visited, i, j);
            }
        }
    }
    
    
    
    public static void Dfs(int[][] matrix, List<List<bool>>visited, int row, int col)
    {
        visited[row][col] = true;
    
        for (var i = 0; i<matrix[0].Length; i++)
        {
            if(!visited[row][i] && matrix[row][i]!= 0)
            {
                matrix[row][i] = 0;
                visited[row][i] = true;
            }
        }
        
        for (var i = 0; i<matrix.Length; i++)
        {
            if(!visited[i][col] && matrix[i][col]!= 0)
            {
                matrix[i][col] = 0;
                visited[i][col] = true;
            }
        }
    }
}