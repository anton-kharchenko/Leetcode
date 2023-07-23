public class Solution {
    public bool Exist(char[][] board, string word) {
        for(var i = 0; i<board.Length; i++){
            for(var j = 0; j<board[0].Length; j++){
                if(Dfs(i, j, board.Length, board[0].Length, word, board, 0)){
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public bool Dfs(int i, int j, int n, int m, string dest, char[][] board, int index){
        if(index == dest.Length) return true;
        
        if(i<0|| j<0|| i>=n|| j>=m || dest[index] != board[i][j]){
            return false;
        }
        
        board[i][j] = '#';
        
        var res = Dfs(i+1, j, n, m, dest, board, index+1) || 
            Dfs(i-1, j, n, m, dest, board,  index+1) ||
            Dfs(i, j+1, n, m, dest, board,  index+1) ||
            Dfs(i, j-1, n, m, dest, board,  index+1);
        
        board[i][j] = dest[index];     
        
        return res;    
    }
}