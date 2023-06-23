public class NumMatrix {
    int[][] dp = null;
    public NumMatrix(int[][] matrix) {
        if(matrix.Length == 0 || matrix[0].Length == 0) return ;
        dp = new int[matrix.Length][];
        
        for(int i=0; i<matrix.Length; i++)
        {
            dp[i] = new int[matrix[0].Length + 1];
            for(int j=0; j<matrix[0].Length; j++)
            {
                dp[i][j+1] = dp[i][j] + matrix[i][j];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
       int sum = 0;
        for(int row = row1; row <= row2; row++)
            sum += dp[row][col2 + 1] - dp[row][col1];
        
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */