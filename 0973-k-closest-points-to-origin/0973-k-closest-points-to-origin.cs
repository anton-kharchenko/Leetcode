public class Solution {
    public int[][] KClosest(int[][] points, int k) {
       var items = points.Select(point=>{
            long fp = point[0];
            long sp = point[1];
            return (point, fp*fp + sp*sp); 
        });
        
        var res = new int[k][];
        
        var queue = new PriorityQueue<int[], long>(items);
        
        for(var i =0; i<k;i++){
            res[i] =  queue.Dequeue();
        }
        
        return res;
    }
}