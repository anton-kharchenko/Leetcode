public class Solution {
    int ans = 0;
    int n = 0;
    int m = 0;
    public int CountBattleships(char[][] board) {
        n = board.Length;
        m = board[0].Length;
        
        for(var i = 0; i<n; i++){
            for(var j = 0; j<m; j++){
                if(board[i][j] == 'X'){
                    Dfs(i, j, board);
                    ans++;
                }
            }
        }
        
        return ans;
    }
    
    public void Dfs(int row, int col, char[][]board){
        if(row<0 || row>= n || col <0 || col>= m || board[row][col] == '.'){
            return;
        }
        
        board[row][col]= '.';
        
        Dfs(row + 1, col, board);
        Dfs(row - 1, col, board);
        Dfs(row, col+1, board);
        Dfs(row, col-1, board);
    }
}