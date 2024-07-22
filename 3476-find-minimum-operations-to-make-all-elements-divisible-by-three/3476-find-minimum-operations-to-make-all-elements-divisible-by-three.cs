public class Solution {
    public int MinimumOperations(int[] nums) {
        var result = 0;
        foreach(var num in nums){
            if(num % 3 != 0){
                result += 1;
            }
        }
        return result;
    }
}