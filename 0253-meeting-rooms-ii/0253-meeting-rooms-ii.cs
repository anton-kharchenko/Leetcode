public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        var length = intervals.Length;
        var start = new int[length];
        var end = new int[length];
        
        for(var i = 0; i<length; i++){
            start[i] = intervals[i][0];
            end[i] = intervals[i][1];
        }
        
        Array.Sort(start);
        Array.Sort(end);
        
        
        var startIndex = 0;
        var endIndex = 0;
        
        var res = 0;
        var count = 0;
        
        while(startIndex< length){
            
            if(start[startIndex]<end[endIndex]){
                startIndex++;
                count++;
            }else{
                endIndex++;
                count--;
            }
            
            res = Math.Max(count, res);
        }
        
        return res;
    }
}