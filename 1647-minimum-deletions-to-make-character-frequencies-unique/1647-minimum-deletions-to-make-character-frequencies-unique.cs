public class Solution {
    public int MinDeletions(string s) {
       int deleted = 0;
       var hs = new HashSet<int>(); 
       foreach(var group in s.GroupBy(i=>i)){
           var count = group.Count();
           while(count>0 && hs.Add(count) == false){
               deleted++;
               count--;
           }
       } 
        
       return deleted; 
    }
}