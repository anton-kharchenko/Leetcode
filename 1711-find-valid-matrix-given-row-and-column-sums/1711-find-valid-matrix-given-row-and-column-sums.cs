public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        var result = new int[rowSum.Length][];
        
        for (var i = 0; i<rowSum.Length; i++)
            result[i] = new int[colSum.Length];

        var col = 0;
        
        while (col < colSum.Length)
        {
            for (int i = 0; i < rowSum.Length; i++)
            {
                result[i][col] = Math.Min(colSum[col], rowSum[i]);
                rowSum[i] -= result[i][col];
                colSum[col] -= result[i][col];
            }
            
            col += 1;
        }
        
        
        return result; 
    }
}