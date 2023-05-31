public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        var target = new List<int>();
        
        
        for(var i = 0; i<nums.Length; i++){
            target.Insert(index[i], nums[i]);
        }
        
        return target.ToArray();
    }
}