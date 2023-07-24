public class Solution {
 public int LongestSubarray(int[] nums, int limit) {
    int result = 0;
     
     for(var i = 0; i<nums.Length; i++){
         var min = nums[i];
         var max = nums[i];
         var iMin = i;
         var iMax = i;
         var count = 0;
         var j = i;
         for( ; j<nums.Length; j++){
             
             if(Math.Abs(nums[j] - min)>limit|| Math.Abs(nums[j] - max)>limit){
                 break;
             }
             
             count++;
             
             if(nums[j]>=max){
                 iMax = j;
                 max = nums[j];
             }
             
              if(nums[j]<=min){
                 iMin = j;
                 min = nums[j];
             }
         }
         
         result = Math.Max(count, result);
         i = Math.Min(iMin, iMax);
     }
     
     return result == 0 && limit>= 0 ? 1 : result;
 }
}