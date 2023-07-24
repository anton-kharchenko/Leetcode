public class Solution {
    public bool Exist(char[][] board, string word) {
        for(var i = 0; i<board.Length; i++){
            for(var j = 0; j<board[0].Length; j++){
                if(Dfs(i, j, board.Length, board[0].Length, board, word, 0)){
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public bool Dfs(int i, int j, int n, int m, char[][] board, string word, int index){
        if(index == word.Length){
            return true;
        }
        
        if(i<0 || j<0 || i>= n || j>=m || board[i][j] != word[index]){
            return false;
        }
        
        board[i][j] = '#';
        
        var res = Dfs(i+1, j, n, m, board, word, index + 1) ||
                  Dfs(i-1, j, n, m, board, word, index + 1) ||
            Dfs(i, j+1, n, m, board, word, index + 1) ||
            Dfs(i, j-1, n, m, board, word, index + 1);
        
        board[i][j] = word[index];
        
        return res;
    }
    
}