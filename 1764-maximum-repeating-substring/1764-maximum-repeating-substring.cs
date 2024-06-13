public class Solution {
    public int MaxRepeating(string sequence, string word)
    {
        var sequenceLength = sequence.Length;
        var wordLength = word.Length;
       
        var result = 0;
        var cache = new int[sequenceLength];

        for(var i = 0; i<sequenceLength; i++){
            if(i + wordLength <= sequenceLength && sequence.Substring(i, word.Length).Equals(word)){
                    cache[i] = 1 + (i - wordLength >= 0 ? cache[i - wordLength] : 0);
            }
            result = Math.Max(result, cache[i]);
        } 

        return result;
    }

}