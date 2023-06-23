public class NumMatrix {
    int[][] grid = null;
    public NumMatrix(int[][] matrix) {
        grid = matrix;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        var sum = 0;
        while(row1<= row2){
            for(var i = col1; i<=col2; i++ ){
                sum += grid[row1][i];
            }
            
            row1++;
        }
        
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */