public class Solution {
    public bool IsHappy(int n) {
        var set= new HashSet<int>();
        
        while(!set.Contains(n)){
            
            set.Add(n);
            
            int sum = 0;
            
            while(n != 0){
                
                int tmp = n % 10;
                
                sum += tmp * tmp; 
                
                n = n/10;
            }
            
            n = sum;
        }
        
        return n == 1;
    }
}