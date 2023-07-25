public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> retval = new List<string>();
        
        List<string> lwords = new List<string>();
        int sublen = 0;
        int words_len = 0;
        foreach(string word in words){
            sublen += word.Length + 1;
            //'+1' is for the space added above
            if(sublen > maxWidth + 1){ 
                string line = BuildLine(lwords, maxWidth, words_len);
                retval.Add(line);
                lwords.Clear();
                //Remember to add back in the current word
                sublen = word.Length + 1;
                words_len = 0;
            }
            lwords.Add(word);     
            words_len += word.Length;       
        }
        
        //Do any remaining words
        if(lwords.Count() > 0 ){
            string line = "";
            foreach(string word in lwords){
                line += $"{word} ";
            }
            //NOTE: 'Trim()' is to remove the space on the last word
            line = line.Trim().PadRight(maxWidth);
            retval.Add(line);
        }
        
        return retval;
    }
    
    private string BuildLine(List<string> words, int maxWidth, int words_len){
        int word_count = words.Count();
        int spaces = maxWidth - words_len;
        
        //Special Cases: Handle a single or double word
        if(word_count == 1){
            return words[0].PadRight(maxWidth);
        }else if (word_count == 2){
            return words[0] + "".PadRight(spaces) + words[1];
        }
        
        StringBuilder sb = new StringBuilder();
        
        //Number of space blocks
        int num_of_spaces = word_count - 1;
        //spaces per space block
        int spaces_per_word = spaces / num_of_spaces;
        //Extra spaces
        int extra = spaces % num_of_spaces;
        
        for(int i = 0; i < word_count; i++){
            string word = words[i];
            sb.Append(word);
            //Append spaces except for the last word
            if( i != word_count - 1)
                sb.Append(' ',spaces_per_word);
            //Check for extra spaces
            if( extra > 0 ){
                sb.Append(' ',1);
                extra--;
            }
        }
        return sb.ToString();
    }
}