public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var length = nums.Length;
        var leftProduct = new int[length];
        var rightProduct = new int[length];
        var result = new int[length];
        Array.Fill(leftProduct, 1);
        Array.Fill(rightProduct, 1);

        for(var i = 1; i<length; i++){
            leftProduct[i] = leftProduct[i - 1] * nums[i-1];
        }

        for(var i = length - 2; i>= 0; i--){
            rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
        }

        for(var i = 0; i<length; i++){
            result[i] = leftProduct[i] * rightProduct[i];
        }

        return result;
    }
}