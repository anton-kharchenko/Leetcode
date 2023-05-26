public class Solution {
    public int CountBinarySubstrings(string s) {
        
        var prev =0;
        var curr =1;
        var sum = 0;
        
        for(var i = 1; i<s.Length; i++)
        {
            if (s[i] != s[i - 1])
            {
                sum += Math.Min(curr, prev); 
                
                prev = curr; 
                
                curr = 1;  
            }
            else
            {
                curr++; 
  
            }
        }
        
        sum += Math.Min(curr,prev); // For the final group
        
        return sum;
    }
}