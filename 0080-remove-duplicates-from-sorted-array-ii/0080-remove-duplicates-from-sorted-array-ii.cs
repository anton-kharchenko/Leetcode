public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var l = 0;
        var r = 0;
        while(r<nums.Length){
            var count = 1;
            
            while(r+1<nums.Length && nums[r] == nums[r+1]){
                r++;
                count++;
            }
            
            var min = Math.Min(2, count);
            
            for(var i = 0; i< min; i++){
                nums[l] = nums[r];
                l++;
            }
            r++;
        }
        
        return l;
    }
}