public class Solution {
    int[][] directions = new int[][]{new []{0,1}, new []{0,-1},  new []{1, 0}, new []{-1, 0}, new []{1,1}, new []{-1, -1}, new []{1, -1},new []{-1, 1}};
    public char[][] UpdateBoard(char[][] board, int[] click) {
        Dfs(board, click[0], click[1]);
        return board;
    }
    
    void Dfs(char[][]board, int r, int c){
      if(r < 0 || r >= board.Length || c < 0 || c >= board[0].Length || board[r][c] == 'B')
        return;  
        
        if(board[r][c] == 'M'){
            board[r][c] = 'X';
            return;
        }
        var mineCount = GetMineCount(board, r, c);
        
        if(mineCount>0){
             board[r][c] = (char)('0'+mineCount);
            return;
        }
        
        if(mineCount  == 0){
            board[r][c] = 'B';
            foreach(var dir in directions){
                int row = dir[0] + r;
                int col = dir[1] + c;
                Dfs(board, row, col);
            }
        }
    }
    
    int GetMineCount(char[][]board, int r, int c){
        int count = 0;
        
        foreach(var dir in directions){
            int row = dir[0] + r;
            int col = dir[1] + c;
            if(row >= 0 && row < board.Length && col >= 0 && col < board[0].Length && board[row][col] == 'M')
                count++;
        }
        
        return count;
    }
}