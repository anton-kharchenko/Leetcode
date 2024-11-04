public class Solution {
    public string CompressedString(string word)
    {
        var comp = new StringBuilder();
        var index = 0;
        while (index < word.Length) {
            var currentChar = word[index];
            var count = 0;
            var end = index;
            while (end < word.Length && word[end] == currentChar && count < 9) {
                count++;
                end++;
            }
            comp.Append(count).Append(currentChar);
            index = end;
        }

        return comp.ToString();
    }
}