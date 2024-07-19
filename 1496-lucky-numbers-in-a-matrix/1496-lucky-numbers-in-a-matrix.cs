public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        var result = new List<int>();
        var visited = new HashSet<(int, int)>();
        for(var i = 0; i<matrix.Length; i++)
        {
            var min = int.MaxValue;
            var row = -1;
            var col = -1;
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (min > matrix[i][j])
                {
                    min = matrix[i][j];
                    row = i;
                    col = j;
                }
                
            }

            visited.Add((row, col));
        }
        
        for(var i = 0; i<matrix[0].Length; i++)
        {
            var max = int.MinValue;
            var row = -1;
            var col = -1;
            for (int j = 0; j < matrix.Length; j++)
            {
                if (max < matrix[j][i])
                {
                    max = matrix[j][i];
                    row = j;
                    col = i;
                }
            }
            
            if (!visited.Add((row, col)))
            {
                result.Add(matrix[row][col]);
            }
        }
        
        
        return result;
    }
}