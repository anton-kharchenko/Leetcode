public class Solution {
    public int[] SortArray(int[] nums) {
        Sort(nums);
        return nums;
    }
    
    public void Sort(int[] nums){
        for(var i = 1; i<nums.Length; i++){
            var v = nums[i];
            var j = i-1;
            while(j>=0 && v<nums[j]){
                nums[j+1] = nums[j];
                j--;
            }
            nums[j+1] = v;
        }
    }
}