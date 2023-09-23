public class Solution {
    public string RemoveDigit(string number, char digit) {
        var index = -1;
        var sb = new StringBuilder();
        var chars = number.ToCharArray();
        
        for(var i = 0; i<number.Length; i++){
            if(number[i] == digit){
                index = i;
                
                if(i+1<number.Length&&number[i]<number[i+1]){
                    break;
                }
            }
        }
        
        
        for(var i = 0; i< chars.Length; i++){
            if(i == index) continue;
            
            sb.Append(chars[i]);
        }
        
        
        return sb.ToString();
    }
    
}