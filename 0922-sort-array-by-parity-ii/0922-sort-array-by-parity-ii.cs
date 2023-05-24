public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int even = 0;
        int odd = 1;
        int[] array = new int[nums.Length];
        foreach(var x in nums)
        {
            if(x%2==0)
            {
                array[even] = x;
                even=even+2;
            } 
            else 
            {
                array[odd] = x;
                odd=odd+2;
            }
        }
        return array;
    }
}