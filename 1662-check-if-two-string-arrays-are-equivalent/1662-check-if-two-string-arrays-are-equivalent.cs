public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) { // T - O(n + m); S - O(n + m) 
        StringBuilder stringBuilder1 = new StringBuilder();
        StringBuilder stringBuilder2 = new StringBuilder();
        
        foreach(string word in word1){
            stringBuilder1.Append(word);
        }
              
        foreach(string word in word2){
            stringBuilder2.Append(word);
        }
        
        return stringBuilder1.ToString()  == stringBuilder2.ToString();
    }
}