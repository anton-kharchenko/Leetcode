public class Solution {
    public int[][] UpdateMatrix(int[][] matrix) {
        if(matrix.Length == 0)
            return matrix;
        
        for(int i = 0; i<matrix.Length; i++){
            for(int j = 0; j<matrix[0].Length; j++){
                if(matrix[i][j] == 1 && !HasZeroNeighbor(i, j, matrix))
                    matrix[i][j] = int.MaxValue;
            }
        }
        
        for(int i = 0; i<matrix.Length; i++){
            for(int j = 0; j<matrix[0].Length; j++){
                if(matrix[i][j] == 1)
                    Dfs(matrix, i, j, 1);
            }
        }
        
        return matrix;
    }
    
    public bool HasZeroNeighbor(int i, int j, int[][] matrix){
        if(i-1 >= 0 && matrix[i-1][j] == 0)
            return true;
        if(i+1 < matrix.Length && matrix[i+1][j] == 0)
            return true;
        if(j-1 >= 0 && matrix[i][j-1] == 0)
            return true;
        if(j+1 < matrix[0].Length && matrix[i][j+1] == 0)
            return true;
        
        return false;
    }
    
    public void Dfs(int[][] matrix, int i, int j, int val){
        if(i < 0 || i >= matrix.Length || j < 0 || j >= matrix[0].Length || matrix[i][j] < val)
            return;
        
        matrix[i][j] = val;
        
        Dfs(matrix, i + 1, j, matrix[i][j] + 1);
        Dfs(matrix, i - 1, j, matrix[i][j] + 1);
        Dfs(matrix, i, j - 1, matrix[i][j] + 1);
        Dfs(matrix, i, j + 1, matrix[i][j] + 1);
    }
}