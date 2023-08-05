public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var res = new List<string>();
        var temp = new List<string>();
        var wordLength = 0;
        var currentLength = 0;
        
        foreach(var word in words){
            currentLength += word.Length + 1;
            if(currentLength > maxWidth + 1){
                var line =  BuildLine(temp, maxWidth, wordLength);
                res.Add(line);
                temp.Clear();
                currentLength = word.Length + 1;
                wordLength = 0;
            }

            wordLength += word.Length;
            temp.Add(word);
        }
        
        
        if(temp.Any()){
            var line = "";
            
            foreach(var i in temp){
                line += $"{i} ";
            }
            
            line = line.Trim().PadRight(maxWidth);
            res.Add(line);
        }
        
        return res;
    }
    
    public string BuildLine(List<string> words, int maxWidth, int wordLength){
        
        var spaces = words.Count - 1;
        var totalSpaces = maxWidth - wordLength;

        
        if(words.Count == 1)
            return words[0].PadRight(maxWidth);
        
        if(words.Count == 2)
            return words[0] + "".PadRight(totalSpaces)  + words[1];
        
        var countSpacesBetweenWords  = totalSpaces / spaces;
        var extra = totalSpaces % spaces;
        
        var sb = new StringBuilder();
        
        for(var i = 0; i<words.Count; i++){
            sb.Append(words[i]);
            
            if(i != words.Count - 1){
             sb.Append(' ', countSpacesBetweenWords);
            }
            
            if(extra>0){
                sb.Append(' ', 1);
                extra --;
            }
            
        }
        
        return sb.ToString();
        
    }
    
}