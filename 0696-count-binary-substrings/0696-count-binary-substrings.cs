public class Solution {
    public int CountBinarySubstrings(string s) {
        var sum = 0;
        var curr = 1;
        var prev = 0;
        
        for(var i = 1; i<s.Length; i++ ){
            
            if(s[i] != s[i-1]){
                sum += Math.Min(prev, curr);
                prev = curr;
                curr = 1;
            }
            else{
               curr++; 
            }
        }
        
        sum += Math.Min(prev, curr);
        
        return sum;
    }
}


// 1