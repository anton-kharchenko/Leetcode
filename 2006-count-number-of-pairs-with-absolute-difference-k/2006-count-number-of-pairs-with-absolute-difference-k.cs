public class Solution {
    public int CountKDifference(int[] nums, int k) {
        var result = 0;
        var length = nums.Length;
        
        for(var i = 0; i<length; i++){
            for(var j = i + 1; j<length; j++){
                if(Math.Abs(nums[i] - nums[j]) ==k && i< j)   result++; 
            
            }
        }
        
        return result;
    }
}