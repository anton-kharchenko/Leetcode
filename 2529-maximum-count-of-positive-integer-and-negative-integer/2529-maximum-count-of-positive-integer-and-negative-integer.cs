public class Solution {
    public int MaximumCount(int[] nums) {
        // return Math.Max(nums.Count(number=>number>0), nums.Count(number=>number<0));
        
        var posNumber = 0;
        var negNumber = 0;
        
        foreach(var number in nums){
            if(number>0){
                posNumber++;
            }
            if(number< 0){
                negNumber++;
            }
        }
        
        return Math.Max(posNumber, negNumber);
    }
}
