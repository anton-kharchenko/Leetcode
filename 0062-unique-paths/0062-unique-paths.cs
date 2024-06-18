public class Solution {
    public int UniquePaths(int m, int n)
    {
        int[,] lookup = new int[m, n];
        
        for (int row = lookup.Length - 1; row >= 0; row--)
        {
            for (int col = lookup.Length - 1; col >= 0; col--)
            {
                if (row == m - 1 && col == n - 1)
                {
                    lookup[row, col] = 1;
                }else if (row == m - 1 && col < n - 1)
                {
                    lookup[row, col] = lookup[row, col + 1];
                }else if (col == n - 1 && row < m - 1)
                {
                    lookup[row, col] = lookup[row + 1, col];
                }
                else if(row < m - 1 && col < n - 1)
                {
                    lookup[row, col] = lookup[row + 1, col] + lookup[row, col + 1]; 
                }
                
            }
        }
        
        return lookup[0, 0];
        //return Recursion(m, n, 1, 1, new int[m + 1, n + 1]);
    }
}