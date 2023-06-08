public class Solution {
    public int ArraySign(int[] nums) {
        var neg = 0;
        
        foreach(var n in nums){
            if(n<0) neg += 1;
            if(n==0) return 0;
        }
        
        return neg % 2 == 0 ? 1 : -1;
    }
}