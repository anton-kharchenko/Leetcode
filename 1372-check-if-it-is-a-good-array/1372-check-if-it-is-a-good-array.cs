public class Solution {
    public bool IsGoodArray(int[] nums) {
        if(nums[0] == 1) return true;
        var prev = nums[0];
        for(var i = 1; i<nums.Length; i++){
            var current = GetGCD(nums[i], prev);
            if(current == 1){
                return true;
            }
            prev = current;
        }

        return false;
    }
    
    public int GetGCD(int a, int b){
        int minValue = Math.Min(a, b);
        var result = minValue;
        while(result > 0){
            if(a % result == 0 && b % result == 0){
                break;
            }
            result -= 1;
        }
        return result;
    }
}