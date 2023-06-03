public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums); // O(n*logn)
        var sum = 0;
        
        for(var i = 0;i<nums.Length; i+=2){ // O(logn)
            sum += nums[i];
        }
        return sum;
    }
}

// Time: O(n*logn) + O(logn) =  O(n*logn)
// Space:  O(n)