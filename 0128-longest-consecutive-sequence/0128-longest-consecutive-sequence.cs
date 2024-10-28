public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0 || nums.Length == 1) return nums.Length;
        int max = 0;
        var hs = new HashSet<int>(nums);
        int index = 0;
        while(index < nums.Length){
            var num = nums[index];
            if(!hs.Contains(num - 1)){
                int count = 0;
                while(hs.Contains(num + count)){
                    count += 1;
                    max = Math.Max(max, count);
                }
            }
            index += 1;
        }

        return max;
    }
}