public class Solution {
    public int UniquePaths(int m, int n)
    {
        return Memo(new int[m + 1, n + 1], 0, 0, m, n);
    }
    
    
    public int Memo(int[,] cache, int row, int col, int m, int n){
        if(row == m || col == n){
            return 0;
        }
        
        if(cache[row, col] >  0){
            return cache[row, col];
        }
        
        if(row == m-1 && col == n-1){
            return 1;
        }
        
        cache[row, col] = Memo(cache, row + 1, col, m, n) + Memo(cache, row, col+1, m, n);
        return cache[row, col];
    }
}