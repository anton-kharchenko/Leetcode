public class Solution {
    public int TrailingZeroes(int n) {
        int result = 0;
        while(n>0){
            n /= 5;
            result += n;
        }
        return result;
    }

}