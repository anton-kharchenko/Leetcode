public class Solution {
    public bool IsPowerOfTwo(int n) {
        
        return (n>0) &&  !Convert.ToBoolean( n & (n-1));
    }
}