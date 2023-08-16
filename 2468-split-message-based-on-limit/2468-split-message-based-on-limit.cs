public class Solution {
public string[] SplitMessage(string message, int limit)
    {
        var messageLength = message.Length;
        var parts = 1;
        var allParts = Length(parts);   
        var ans = new List<string>();
    
        while(parts*(3 + Length(parts)) + allParts + messageLength > limit * parts){
            if((3 + Length(parts)* 2)  >= limit){
                return ans.ToArray(); 
            }
            parts++;
            allParts += Length(parts);
        }
    
    
        for(var i = 1; i<=parts; i++){
            
            var textLength = Math.Min(message.Length, limit - (3 + Length(i) + Length(parts)));
            var chunk = message.Substring(0, textLength);
            message = message.Substring(textLength);
            ans.Add($"{chunk}<{i}/{parts}>");
        }
    
    
        return ans.ToArray();
    }
    
    
    public int Length(int value){
        return value.ToString().Length;
    }
}