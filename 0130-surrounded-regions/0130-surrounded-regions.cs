public class Solution {
    public void Solve(char[][] board) {
        var n = board.Length;
        var m = board[0].Length;
     // 1. Change O to T
        for(var i = 0; i<n; i++){
           for(var j = 0; j<m; j++){
                if(board[i][j]=='O'){
                  if(i==0 ||j ==0 || i==n-1 || j==m-1){
                   Dfs(board, i, j);
                }
            }
          }  
        }
     // 2. Change O to X
        for(var i = 0; i<n; i++){
             for(var j = 0; j<m; j++){
                 if(board[i][j]=='O'){
                     board[i][j] = 'X';
                 }
             }
        }
     // 3. Change T to O
        for(var i = 0; i<n; i++){
             for(var j = 0; j<m; j++){
                 if(board[i][j]=='T'){
                     board[i][j] = 'O';
                 }
             }
        }
    }
    
    public void Dfs(char[][]board, int i, int j){
        if(i<0 || j<0 ||i>= board.Length || j>= board[0].Length || board[i][j] != 'O'){
            return;
        }
        
        board[i][j] = 'T';
        Dfs(board, i+1, j);
        Dfs(board, i-1, j);
        Dfs(board, i, j+1);
        Dfs(board, i, j-1);
    }
}