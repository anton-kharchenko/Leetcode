public class Solution {
    public void SortColors(int[] nums) {
        for(var i = 0; i<nums.Length; i++){
            var minIndex = i;
            for(var j = i + 1; j<nums.Length; j++){
                if(nums[j]<nums[minIndex]){
                    minIndex = j;
                }
            }
            (nums[minIndex], nums[i]) = (nums[i], nums[minIndex]);
        }
    }
}