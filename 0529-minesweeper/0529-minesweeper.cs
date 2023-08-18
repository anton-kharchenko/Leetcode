public class Solution {
        int n = 0;
        int m = 0;
        int[][] directions = new int[][]{new []{0,1}, new []{0,-1},  new []{1, 0}, new []{-1, 0}, new []{1,1}, new []{-1, -1}, new []{1, -1},new []{-1, 1}};
    public char[][] UpdateBoard(char[][] board, int[] click) {
        n = board.Length;
        m = board[0].Length;
        
        Dfs(board, click[0], click[1]);
        return board;
    }
    
    void Dfs(char[][] board, int row, int col){
        if(row<0 || col < 0 ||row>=n || col >= m || board[row][col] == 'B'){
            return;
        }
        
        if(board[row][col] == 'M'){
            board[row][col] = 'X';
            return;
        }
        
        var getMineNumber = GetMineNumber(board, row, col);
       
        if(getMineNumber > 0){
             board[row][col] = (char) (getMineNumber + '0');
             return;
        }
        
        if(getMineNumber==0){
            board[row][col] ='B';
            foreach(var dir in directions){
                var r = row + dir[0];
                var c = col + dir[1];
                Dfs(board, r, c);
            }
        }
        
    }
    
    int GetMineNumber(char[][] board, int row, int col){
        int count = 0;
        
        foreach(var dir in directions){
            int r = row + dir[0];
            int c = col + dir[1];
            if(r>=0 && c>=0 && r<n && c<m && board[r][c] == 'M')
                count++;
        }
        
        return count;
    }

}