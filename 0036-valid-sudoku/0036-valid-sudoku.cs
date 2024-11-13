public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var uniqueNumbers = new HashSet<int>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.' && uniqueNumbers.Contains(board[i][j]))
                    return false;
                uniqueNumbers.Add(board[i][j]);
            }
            uniqueNumbers.Clear();
        }
        
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[j][i] != '.' && uniqueNumbers.Contains(board[j][i]))
                    return false;
                uniqueNumbers.Add(board[j][i]);
            }
            uniqueNumbers.Clear();
        }
        
        for (int i = 0; i < 9; i+=3)
        {
            for (int j = 0; j < 9; j+=3)
            {
              var visited = new HashSet<char>();
              for (int n = 0; n < 3; n++)
              {
                  for (int m = 0; m < 3; m++)
                  {
                      if (board[n+i][m+j] != '.' && visited.Contains(board[n+i][m+j]))
                          return false;
                      visited.Add(board[n+i][m+j]);
                  }
              }
            }
        }
        
        return true;
    }
}