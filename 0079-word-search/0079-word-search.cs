public class Solution {
    public bool Exist(char[][] board, string word) {
        
        for(var i = 0; i<board.Length; i++){
            for(var j = 0; j<board[0].Length; j++){
                    if(Dfs(board, i, j, word, 0)){
                        return true;
                    }
            }
        }
        
        return false;
    }
    
   bool Dfs(char[][] board, int row, int col, string word, int index) {
       
        if(index == word.Length){
            return true;
        }
        
        if( row < 0|| col < 0|| row >= board.Length || col >= board[0].Length || board[row][col] != word[index]){
            return false;
        }
       
        board[row][col] = '#';
       
        var res= Dfs(board, row + 1, col, word, index+1)
            || Dfs(board, row - 1, col, word, index+1)
            || Dfs(board, row, col+1, word, index+1)
            || Dfs(board, row, col-1, word, index+1);
       
        board[row][col] = word[index];
       
       return res;
    }
}