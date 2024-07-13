 public class Solution {
     public bool CanAttendMeetings(int[][] intervals) {
         var sorted = intervals.OrderBy(i=>i[0]).ToArray();
         for(var i = 0; i<sorted.Length - 1; i++){ 
             var currentInterval = sorted[i];
             var nextInterval = sorted[i + 1];
             if(nextInterval[0] < currentInterval[1]){
                 return false;
             }
         }
         return true;
     }
 }