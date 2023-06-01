public class Solution {
    public int LastRemaining(int n) {
    if(n==1)
        {
            return 1;
        }
        
        int left=n/2;
        return 2*(left-LastRemaining(left)+1);
    }
}