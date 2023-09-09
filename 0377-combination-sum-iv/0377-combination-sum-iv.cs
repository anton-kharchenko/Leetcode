public class Solution {
    public int CombinationSum4(int[] nums, int target) {
      var comb = new int[target + 1];
      comb[0] = 1;
        
        for(var i = 1; i<=target; i++){
            for(var j = 0; j<nums.Length;j++ ){
                if(i-nums[j]>= 0){
                    comb[i] += comb[i - nums[j]];
                }
            }
        }
        
        
      return comb[target];  
    }
}