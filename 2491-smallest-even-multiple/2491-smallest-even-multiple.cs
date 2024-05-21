public class Solution {
    public int SmallestEvenMultiple(int n) {
        if(n % 2 == 1){
            n *= 2;
        }
        return n;
    }
}