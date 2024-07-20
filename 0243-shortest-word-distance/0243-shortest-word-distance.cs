public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        var firstIndex = -1;
        var secondIndex = -1;
        var result = int.MaxValue;
        for (int i = 0; i < wordsDict.Length; i++)
        {
            if (wordsDict[i] == word1)
            {
                firstIndex = i;
            }
            
            if (wordsDict[i] == word2)
            {
                secondIndex = i;
            }

            if (firstIndex != -1 && secondIndex != -1)
            {
                result = Math.Min(Math.Abs(firstIndex - secondIndex), result);
            }
        }
        
        return result;
    }
}