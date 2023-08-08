public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var ans = new List<string>();
        var wordLength = 0;
        var temp = new List<string>();
        var count = 0;
        
        foreach(var word in words){
            count += word.Length + 1;
            
            if(count>maxWidth+1){
                var line = Builder(temp, maxWidth, wordLength);
                ans.Add(line);
                temp.Clear();
                count = word.Length + 1;
                wordLength = 0;
            }
            
            temp.Add(word);
            wordLength += word.Length;
        }
        
        if(temp.Any()){
            var line = "";
            foreach(var i in temp){
                line += $"{i} ";
            }
            
          line = line.Trim().PadRight(maxWidth, ' ');
          ans.Add(line);
        }
        
        
        
        return ans;
    }
    
    
    public string Builder(List<string> words,  int maxWidth, int wordLength){
        var length = words.Count;
        var spaces = words.Count  - 1 ;
        var totalSpaces = maxWidth -  wordLength;

        
        if(length == 1)
            return words[0].PadRight(maxWidth, ' ');
        
        if(length == 2)
            return words[0]  + "".PadRight(totalSpaces, ' ') + words[1];
        
        var sb = new StringBuilder();
        
        var spacesPerWord = totalSpaces / spaces;
        var extra = totalSpaces % spaces; 
        
        for(var i = 0; i<length; i++){
            var word = words[i];
            
          
            
            sb.Append(word);
            
            if(i<length - 1){
                sb.Append(' ', spacesPerWord);
            }
            
            if(extra>0){
                sb.Append(' ', 1);
                extra--;
            }
        }
        
        return sb.ToString();
    }
}