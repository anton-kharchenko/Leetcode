public class Solution {
    public int MaximumCount(int[] nums) {
       return Math.Max(nums.Count(n=>n>0), nums.Count(n=>n<0));
        
//         var p = 0;
//         var n = 0;
//         for(var i = 0; i<nums.Length; i++ ){
//             if(nums[i]<0){
//                 n++;
//             }
//             if(nums[i]>0){
//                 p++;
//             }
//         }
        
//         return Math.Max(p, n);
    }
}