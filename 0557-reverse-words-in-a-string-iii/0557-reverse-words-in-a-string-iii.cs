public class Solution {
    public string ReverseWords(string s) {
        int count  = 0;
        var sb = new StringBuilder(s);
        
        for(var i = sb.Length - 1;i>=0; i--){
            count++;
            if(sb[i] == ' ' || i==0){
                    int k = i+count-1;
                for(int j = i == 0 ? 0: i+1; j < k; j++) {
                    (sb[j], sb[k]) = (sb[k], sb[j]);
                    k--;
                }
       
                  count = 0;
            }
          
        }
        
        return sb.ToString();
    }
}