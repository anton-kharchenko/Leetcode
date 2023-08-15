public class Solution {
    int[,] directions = new int[,]{ {0,1}, {1, 0}, {-1, 0}, {0, -1}};
    int gate = 0;
    int wall = -1;
    int mt = int.MaxValue;
    public void WallsAndGates(int[][] rooms) {
       
       int m = rooms.Length;
       int n = rooms[0].Length;
       var q = new Queue<(int, int)>();
        
       for(var i = 0; i<m; i++){
           for(var j = 0; j<n; j++){
               if(rooms[i][j] == gate){
                 q.Enqueue((i, j));
               }
              
           }
       } 
       
        while(q.Count> 0){
            var x = q.Dequeue();
            
            for(var i = 0; i<4; i++){
                var row = x.Item1 + directions[i, 0];
                var col = x.Item2 + directions[i, 1];
                if(row>=0 && col>=0&&row<m&& col<n&& rooms[row][col] == mt && rooms[row][col] != wall){
                    rooms[row][col] = rooms[x.Item1][x.Item2] + 1;
                    q.Enqueue((row, col));
                }
            }
        }
    }
}