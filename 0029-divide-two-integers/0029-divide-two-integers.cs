public class Solution {
    public int Divide(int dividend, int divisor) {
       if(dividend == int.MinValue && divisor == -1) return  int.MaxValue;
        var sign = dividend> 0 ^ divisor> 0 ? -1 : 1;
        var res = 0;
        long m = Math.Abs((long) dividend);
        long n = Math.Abs((long) divisor);
        
        
        while(m>=n){
            long subN = n;
            for(var i = 1; m>= subN; i<<=1, subN<<=1){
                m -= subN;
                res += i;
            }
        }
        
        return res * sign;
    }
}