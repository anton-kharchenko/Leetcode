public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var writeIndex = 1;

        for(var readIndex = 1; readIndex<nums.Length; readIndex++){
            if(nums[readIndex] != nums[readIndex - 1]){
                nums[writeIndex] = nums[readIndex];
                writeIndex += 1;
            }
        }

        return writeIndex;
    }
}