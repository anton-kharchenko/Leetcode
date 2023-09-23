public class Solution {
    public string RemoveDigit(string number, char digit) {
        var indexToRemove = -1;
        var sb = new StringBuilder();
        var arr = number.ToCharArray();
        
        for(var i = 0; i<number.Length; i++){
            if(number[i]== digit){
                indexToRemove = i;
                if(i+1<number.Length && number[i]<number[i+1])
                    break;
            }
        }
        
        for(var i = 0; i< arr.Length; i++){
            if(i == indexToRemove) 
                continue;
            
            sb.Append(arr[i]);
        }
        
        return sb.ToString();
    }
    
}