public class Solution {
public int ShortestPathBinaryMatrix(int[][] grid)
{
    if(grid == null || grid[0].Length == 0 || grid[0][0] != 0)
            return -1;
    
    var queue = new Queue<(int, int)>();
    
    var directions = new int[,]
        { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 }, { 1, 1 }, { -1, -1 }, { 1, -1 }, { -1, 1 } };
    
    int n = grid.Length, m = grid[0].Length, length = 0;
    
    var visited = new bool[n, m];
    
    queue.Enqueue((0, 0));
    
    visited[0, 0] = true;

    while (queue.Count > 0)
    {
        length++;
        var size = queue.Count;
        
        for (var i = 0; i < size; i++)
        {
            var node = queue.Dequeue();
            
            if (node.Item1 == n - 1 && node.Item2 == m - 1)
            {
                return length;
            }


            for (var j = 0; j < 8; j++)
            {
                int nextRow = node.Item1 + directions[j, 0];
                int nextCol = node.Item2 + directions[j, 1];

                if (nextRow >= 0 && nextCol >= 0 && nextRow < n && nextCol < m && grid[nextCol][nextRow] == 0 &&
                    !visited[nextRow, nextCol])
                {
                    queue.Enqueue((nextRow, nextCol));
                    
                    visited[nextRow, nextCol] = true;
                }
            }
        }
    }

    return -1;
}
}