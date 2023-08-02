public class Solution {
    int n = 0;
    int m = 0;
    public bool Exist(char[][] board, string word) {
        n = board.Length;
        m = board[0].Length;
        
        for(var i = 0; i<n; i++ ){
            for(var j = 0; j<m; j++){
                if(Dfs(i, j, word, 0, board)){
                    return true;
                }
            }
        }
        
        
        return false;
    }
    
    
    public bool Dfs(int i, int j, string word, int index, char[][]board){
        if(index == word.Length){
            return true;
        }
        
        if(i>= n|| j>=m || i<0|| j<0|| word[index] != board[i][j]){
            return false;
        }
        
        board[i][j] = '#';
        
        var res = Dfs(i+1, j, word, index + 1, board) || 
        Dfs(i-1, j, word, index + 1, board) || 
            Dfs(i, j+1, word, index + 1, board) || 
            Dfs(i, j-1, word, index + 1, board);
        
        board[i][j] = word[index];
        
        return res;
    }

    
}