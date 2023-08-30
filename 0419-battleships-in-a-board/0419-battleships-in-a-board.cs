public class Solution {
    int ans = 0;
    int m = 0;
    int n = 0;
    public int CountBattleships(char[][] board) {
        m = board.Length;
        n = board[0].Length;
        
        for(var i = 0; i<m; i++){
            for(var j = 0; j<n; j++){
                if(board[i][j] == 'X'){
                    ans++;
                    Dfs(i, j, board);
                }
            }
        }
        
        return ans;
    }
    
    
    public void Dfs(int row, int col, char[][] board){
        if(row<0 || col<0 || row >= m || col >= n || board[row][col] == '.'){
            return;
        }
        
        board[row][col] = '.';
        Dfs(row+1, col, board);
        Dfs(row-1, col, board);
        Dfs(row, col+1, board);
        Dfs(row, col-1, board);
    }
}