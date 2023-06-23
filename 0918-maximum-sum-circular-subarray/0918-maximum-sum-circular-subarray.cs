public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
      var max = Int32.MinValue;
      var currMax = 0;
      var min = Int32.MaxValue;
      var currMin = 0;
      var total = 0;
        
      for(var i = 0; i<nums.Length; i++){
            var n = nums[i];
          
            currMax = Math.Max(currMax + n, n);
            currMin = Math.Min(currMin + n, n);
          
            max  =  Math.Max(max, currMax); 
            min  =  Math.Min(min, currMin);
          
           total += n;
        }
        
       if(max<0) return max;
       return  Math.Max(max, total - min);
    }
       
}