public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var count1= 0;
        var count2 = 0;
        var res = "";
        
        while(count1!= word1.Length && count2!= word2.Length){
            if(count1!= word1.Length) res+= word1[count1++];
            if(count2!= word2.Length) res+= word2[count2++];    
        }
        
        
        while(count1!= word1.Length){
            res+= word1[count1++];  
        }
        
        while(count2!= word2.Length){
            res+= word2[count2++];  
        }
        
        return res;
    }
}