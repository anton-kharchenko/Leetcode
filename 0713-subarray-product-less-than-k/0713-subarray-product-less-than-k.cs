public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        int count = 0;
        int product = 1;
        int start = 0;
        
        for(var i= 0; i<nums.Length; i++ ){
            product *= nums[i];
            
        while(start < i && product >= k)
		{
			product /= nums[start];
			start++;
		}
            
            if(product <k){
                count += (i - start + 1);
            }
        }
        
        return count;
    }
}