public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend == int.MinValue && divisor == -1) 
            return  int.MaxValue;
        
        var sign = dividend> 0 ^ divisor> 0 ? -1 : 1;
        var res = 0;
        var m = Math.Abs((long) dividend);
        var n = Math.Abs((long) divisor);
        
        while(m>=n){
                m -= n;
                res++;
        }
    
        return res * sign;
    }
}