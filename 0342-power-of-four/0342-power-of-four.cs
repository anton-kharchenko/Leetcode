public class Solution {
    public bool IsPowerOfFour(int n) {
        if(n==0){
            return false;
        }
        if(n == 1){
            return true;
        }
        
        return IsPowerOfFour(n/4) && n%4==0 ? true: false;
    }
}