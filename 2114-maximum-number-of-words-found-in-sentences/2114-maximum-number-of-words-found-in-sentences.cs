public class Solution {
    public int MostWordsFound(string[] sentences) {
        var max = 0;
        
        foreach(var sentence in sentences){
            var current = sentence.Count(i=> i == ' ') + 1;
            max = Math.Max(current, max);
        }
        
        return max;
    }
}