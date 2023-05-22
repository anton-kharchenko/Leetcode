public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var l = 0;
        var r = nums.Length - 1;
        var res = new int[nums.Length];
        var count = 0;
        var mid = n;
        
        while(mid<=r){
            res[count++] = nums[l];
            res[count++] = nums[mid];
            l++; 
            mid++;
        }
        
        return res;
    }
}