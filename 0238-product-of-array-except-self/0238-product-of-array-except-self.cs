public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var leftProd = new int[nums.Length];
        var rightProd = new int[nums.Length];
        var product = new int[nums.Length];
        Array.Fill(leftProd, 1);
        Array.Fill(rightProd, 1);
        
        for (int i = 1; i < nums.Length; i++)
        {
            leftProd[i] = nums[i - 1] * leftProd[i - 1];
        }
        
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            rightProd[i] = nums[i + 1] * rightProd[i + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            product[i] = leftProd[i] * rightProd[i];
        }
            
        return product;
    }
}