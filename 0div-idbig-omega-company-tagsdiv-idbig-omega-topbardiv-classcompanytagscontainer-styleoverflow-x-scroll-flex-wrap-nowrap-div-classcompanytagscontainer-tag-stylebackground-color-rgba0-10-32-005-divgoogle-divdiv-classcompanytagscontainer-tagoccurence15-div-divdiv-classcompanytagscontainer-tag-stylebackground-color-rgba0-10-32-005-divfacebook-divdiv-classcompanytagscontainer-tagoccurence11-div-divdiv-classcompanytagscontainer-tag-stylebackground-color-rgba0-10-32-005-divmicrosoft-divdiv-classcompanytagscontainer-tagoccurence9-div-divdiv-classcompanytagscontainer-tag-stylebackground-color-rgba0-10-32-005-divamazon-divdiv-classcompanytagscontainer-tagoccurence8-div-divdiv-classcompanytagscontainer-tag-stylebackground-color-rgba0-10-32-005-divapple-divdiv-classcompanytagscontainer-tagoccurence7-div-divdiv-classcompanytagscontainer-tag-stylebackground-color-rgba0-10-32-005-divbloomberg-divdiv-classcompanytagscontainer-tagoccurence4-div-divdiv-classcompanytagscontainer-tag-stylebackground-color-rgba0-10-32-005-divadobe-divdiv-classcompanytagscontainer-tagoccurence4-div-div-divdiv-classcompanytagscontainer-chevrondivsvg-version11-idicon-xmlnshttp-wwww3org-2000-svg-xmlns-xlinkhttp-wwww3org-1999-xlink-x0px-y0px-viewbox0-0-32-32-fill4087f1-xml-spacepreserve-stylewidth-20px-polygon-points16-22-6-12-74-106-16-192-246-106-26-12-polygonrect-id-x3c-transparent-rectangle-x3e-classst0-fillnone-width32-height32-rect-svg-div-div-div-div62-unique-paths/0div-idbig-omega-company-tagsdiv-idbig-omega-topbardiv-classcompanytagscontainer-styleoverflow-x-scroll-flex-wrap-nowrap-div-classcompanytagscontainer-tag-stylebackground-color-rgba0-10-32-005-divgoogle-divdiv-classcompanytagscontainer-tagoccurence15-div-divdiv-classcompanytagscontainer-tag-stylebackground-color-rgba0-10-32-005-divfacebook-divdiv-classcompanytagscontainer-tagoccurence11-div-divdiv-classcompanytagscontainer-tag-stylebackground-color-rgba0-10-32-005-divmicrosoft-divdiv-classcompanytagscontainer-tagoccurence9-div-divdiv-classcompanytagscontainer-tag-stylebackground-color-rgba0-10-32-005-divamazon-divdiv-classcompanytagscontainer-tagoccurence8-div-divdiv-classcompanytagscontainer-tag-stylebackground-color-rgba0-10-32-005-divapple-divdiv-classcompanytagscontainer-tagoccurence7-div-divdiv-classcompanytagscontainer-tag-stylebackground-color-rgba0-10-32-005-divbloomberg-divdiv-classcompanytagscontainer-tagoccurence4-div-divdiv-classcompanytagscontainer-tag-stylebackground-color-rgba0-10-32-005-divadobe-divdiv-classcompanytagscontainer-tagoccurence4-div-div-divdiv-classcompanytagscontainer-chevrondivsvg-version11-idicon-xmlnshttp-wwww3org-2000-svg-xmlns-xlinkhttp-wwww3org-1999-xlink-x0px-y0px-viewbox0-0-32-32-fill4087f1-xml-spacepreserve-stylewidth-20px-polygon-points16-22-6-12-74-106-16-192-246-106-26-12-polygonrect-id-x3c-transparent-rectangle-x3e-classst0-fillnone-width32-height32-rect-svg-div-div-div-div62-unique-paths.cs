public class Solution {
    public int UniquePaths(int m, int n)
    {
        return Memo(0, 0, m, n, new int[m + 1, n + 1]);
    }
    
    public int Memo(int row, int col, int m, int n, int[,] cache){
        if(row == m || col == n){
            return 0;
        }
        
        if(row == m -1 && col == n -1){
            return 1;
        }
        
        if(cache[row, col]> 0){
            return cache[row, col];
        }
            
        cache[row, col] = Memo(row +1, col, m, n, cache) + Memo(row, col+1, m, n, cache);
        
        return cache[row,col];
    }
}