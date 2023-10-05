public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var visited = new HashSet<int>();
        
        for(var i = 0; i<9; i++){
              for(var j = 0; j<9; j++){
                  if(board[i][j] != '.' &&visited.Contains(board[i][j])){
                      return false;
                  }
                  visited.Add(board[i][j]);
              }  
            visited.Clear();
        }
        
        for(var i = 0; i<9; i++){
              for(var j = 0; j<9; j++){
                  if(board[j][i] != '.' && visited.Contains(board[j][i])){
                      return false;
                  }
                  visited.Add(board[j][i]);
              }  
            visited.Clear();
        }
        
        for(var i = 0; i<9; i +=3){
              for(var j = 0; j<9; j+=3){
                 var hs = new HashSet<int>();
                  for(var n = 0;n<3; n++){
                      for(var m = 0; m<3; m++){
                         if(board[i+n][j+m] != '.' && hs.Contains(board[i+n][j+m])){
                              return false;
                       }
                      hs.Add(board[i+n][j+m]); 
                      }
                  }
              }  
           
        }
        
        
        return true;
    }
}