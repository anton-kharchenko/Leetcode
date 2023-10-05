public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return 1;
        
        var hashSet = new HashSet<int>(nums);
        var longestConsecuteve = 0;
        
        foreach(var num in hashSet){
            
            if(!hashSet.Contains(num - 1)){
              var length = 0;
              while(hashSet.Contains(num + length)){
                length++;
                longestConsecuteve = Math.Max(longestConsecuteve, length);
               }
                
              }

           }

        return longestConsecuteve;
    }
}