public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
       var length = nums.Length;
       var times = new int[length + 1];
       var ans = 0;
       for(var i = 0; i < nums.Length; i++){
            if(i != 0){
                times[i] += times[i - 1];
            }

            if(GetIndex(times, nums, i) == 0){
                ans += 1;
                if(i + k - 1 >= length){
                    return - 1;
                }
                Revert(times, i, i + k);
            }
       }

       return ans;
    }

    public void Revert(int[] times, int index1, int index2){
        times[index1] += 1;
        times[index2] -= 1;
    }

    public int GetIndex(int[] times, int[] nums, int index){
        if(times[index] > 0){
            if((times[index] & 1) == 1){
                nums[index] = 1 - nums[index];
            }
        }

        return nums[index];
    }
}