public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var res = new List<string>();
        var remainingList = new List<string>();
        var subSetLength = 0;
        var wordLength = 0;
        
        foreach(var word in words){
            subSetLength += word.Length + 1;
            
            if(subSetLength> maxWidth + 1){
                var line = BuildLine(remainingList, wordLength,  maxWidth);
                res.Add(line);
                remainingList.Clear();
                subSetLength = word.Length + 1;
                wordLength = 0;
            }
            
            remainingList.Add(word);
            wordLength += word.Length; 
        }
        
        if(remainingList.Any()){
            var line = "";
            foreach(var w in remainingList){
                line += $"{w} ";
            }
            
           line = line.Trim().PadRight(maxWidth);
            res.Add(line);
        }
        
        return res;
    }
    
    public string BuildLine(List<string> words, int wordLength, int maxWidth){
        var wordCount = words.Count;
        var totalSpaces = maxWidth - wordLength;
        
        if(wordCount == 1)
            return words[0].PadRight(maxWidth);
        if(wordCount == 2)
            return words[0] + "".PadRight(totalSpaces) + words[1];
        
        var sb = new StringBuilder();
        
        var numberOfSpaces = wordCount -1;
        var spacesPerWord = totalSpaces / numberOfSpaces;
        var extra = totalSpaces % numberOfSpaces;
        
        for(var i = 0; i<words.Count; i++){
            sb.Append(words[i]);
            
           if(i != wordCount - 1){
                sb.Append(' ', spacesPerWord);
            }
            if(extra>0
              ){
                sb.Append(' ', 1);
                extra--;
            }
        }
        
        return sb.ToString();
        
    }
    
}