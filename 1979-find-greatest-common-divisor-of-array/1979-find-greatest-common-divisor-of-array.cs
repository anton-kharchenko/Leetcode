public class Solution {
    public int FindGCD(int[] nums) {
        int maxValue = nums.Max();
        int minValue = nums.Min();
        return GCD(maxValue, minValue);
    }
    
    private int GCD(int a, int b){
        if(b==0){
            return a;
        }
        return GCD(b, a%b);
    }
}