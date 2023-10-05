public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       var ans = new int[nums.Length];
       var rightProduct = new int[nums.Length];
       var leftProduct = new int[nums.Length];
       
       Array.Fill(rightProduct, 1);
       Array.Fill(leftProduct, 1); 
       
       for(var i = 1; i<nums.Length; i++){
           leftProduct[i] = leftProduct[i - 1] *  nums[i - 1];
       } 
      
        for(var i = nums.Length - 2; i>=0; i--){
            rightProduct[i] = rightProduct[i + 1] * nums[i+1]; 
        }
        
       for(var i = 0; i<nums.Length; i++){
          ans[i] = leftProduct[i] * rightProduct[i];      
       } 
       
        
        
       return ans;  
    }
}