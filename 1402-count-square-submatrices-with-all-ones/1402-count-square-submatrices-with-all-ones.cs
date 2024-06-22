public class Solution {
    public int CountSquares(int[][] matrix) {
        var result = 0;
        var lookup = new int[matrix.Length, matrix[0].Length];

        for(var i = 0; i<matrix.Length; i++){
            for(var j = 0; j<matrix[0].Length; j++){
                if(matrix[i][j] == 1){
                    var square = Dfs(matrix, i, j, lookup);
                    result += square;
                }
            }
        }

        return result;
    }

    public int Dfs(int[][] matrix, int row, int col, int[,] lookup){
        if(row == matrix.Length || col == matrix[0].Length || matrix[row][col] == 0){
            return 0;
        }

        if(lookup[row, col] != 0){
            return lookup[row, col];
        }

        lookup[row, col] =  1 + Math.Min(
            Math.Min(Dfs(matrix, row + 1, col, lookup), Dfs(matrix, row, col + 1, lookup)),
            Dfs(matrix, row + 1, col + 1, lookup));

        return  lookup[row, col];
    }
}