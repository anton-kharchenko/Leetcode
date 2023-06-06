public class Solution {
    public int[] RearrangeArray(int[] nums) {
        var l =  0;
        var r =  nums.Length - 1;
        Array.Sort(nums);
        var res = new int[nums.Length];
        var index = 0;
        
        while(index<nums.Length){
           if(index<nums.Length) res[index++] = nums[l++];
           if(index<nums.Length) res[index++] = nums[r--]; 
        }
        
        return res;
    }
}