public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var length = nums.Length;

        var left = new int[length];
        Array.Fill(left, 1);
        for (int i = 1; i < length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }

        var right = new int[length];
        Array.Fill(right, 1);
        for (int i = length - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * nums[i + 1];
        }

        var product = new int[length];

        for (int i = 0; i < length; i++)
        {
            product[i] = left[i] * right[i];
        }

        return product;
    }
}