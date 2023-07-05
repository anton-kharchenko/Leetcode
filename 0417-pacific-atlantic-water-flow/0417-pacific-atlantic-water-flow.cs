public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        List<IList<int>> res = new();
        int m = heights.Length, n = heights[0].Length;
        
        var isPacific = new bool[m, n];
        var isAtlantic = new bool[m, n];
        
        for(int row = 0; row < m; row++)
        {
            DFS(row, 0, heights, isPacific, heights[row][0]);
            DFS(row, n - 1, heights, isAtlantic, heights[row][n - 1]);
        }
        
        for(int col = 0; col < n; col++)
        {
            DFS(0, col, heights, isPacific, heights[0][col]);
            DFS(m - 1, col, heights, isAtlantic, heights[m - 1][col]);
        }
        
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                if(isPacific[i, j] && isAtlantic[i, j])
                    res.Add(new List<int> { i, j });
        
        return res;
    }


    private void DFS(int row, int col, int[][] heights, bool[,] reach, int prev)
    {
        int m = heights.Length, n = heights[0].Length;
        
        if(row < 0 || row >= m || col < 0 || col >= n || reach[row, col] || heights[row][col] < prev)
            return ;
        
        reach[row, col] = true;
        
        DFS(row, col + 1, heights, reach, heights[row][col]);
        DFS(row, col - 1, heights, reach, heights[row][col]);
        DFS(row + 1, col, heights, reach, heights[row][col]);
        DFS(row - 1, col, heights, reach, heights[row][col]);
    }
}