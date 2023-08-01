public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return 1;
        
        Array.Sort(nums); // O(nlogn)
        
        int max = 0, count = 0;
        
        for(var i = 0; i<nums.Length - 1; i++){
            var curr = nums[i];
            var nextNumber = nums[i+1];
            
            if(nextNumber - curr == 1){
                count++;
            }
            
            if(nextNumber - curr> 1){
                count = 0;
            }
            
            max = Math.Max(max, count);
        }
        
        
        return max + 1;
    }
}
  // [100,4,200,1,3,2]
  // 1,2,3,4,100