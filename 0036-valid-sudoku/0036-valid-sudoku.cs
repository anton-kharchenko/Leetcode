public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var row = new HashSet<int>();
      
        
        for(var i = 0; i<9; i++){
            for(var j = 0; j<9; j++){
                var curr = board[i][j];
                if(curr != '.' && row.Contains(curr)  ){
                    return false;
                }else{
                    row.Add(curr);
                }
            }
            row.Clear();
        }
        
        for(var i = 0; i<9; i++){
            for(var j = 0; j<9; j++){
                var curr = board[j][i];
                if(curr != '.' && row.Contains(curr)){
                    return false;
                }else{
                    row.Add(curr);
                }
            }
            row.Clear();
        }
        
        
        for(int i = 0; i < 9; i += 3)
        {
            for(int j = 0; j < 9; j += 3)
            {
                HashSet<char> set = new();
                for(int m = 0; m < 3; m++)
                {
                    for(int n = 0; n < 3; n++)
                    {
                        if(board[i + m][j + n] != '.')
                        {
                            if(set.Contains(board[i + m][j + n]))
                                return false;
                            else
                                set.Add(board[i + m][j + n]);
                        }
                    }
                }
            }
        }
        

        return true;
    }
}