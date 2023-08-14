public class Solution {
    public int[][] Merge(int[][] intervals) {
        intervals = intervals.OrderBy(i=>i[1]).OrderBy(i=>i[0]).ToArray();
        var start = int.MaxValue;
        var end = 0;
        var ans = new List<int[]>();
        var n = intervals.Length;
        
        
        for(var i = 0; i<n; i++){
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            
            
            if( i+1 == n || intervals[i+1][0]>end){
                 ans.Add(new int[2]{start, end});
                 start = int.MaxValue;
                 end = 0;
            }
           
        }
        
        return ans.ToArray();
    }
}