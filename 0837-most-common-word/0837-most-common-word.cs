using System.Text;

public class Solution
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var map = new Dictionary<string, int>();
        var arr = paragraph
            .Replace("!", " ")
            .Replace("?", " ")
            .Replace("'", " ")
            .Replace(",", " ")
            .Replace(";", " ")
            .Replace(".", " ")
            .Replace("/", " ")
            .ToLower()
            .Split(' ');

        foreach (var el in arr)
        {
            var word = new StringBuilder();
            foreach (var letter in el)
                if (char.IsLetterOrDigit(letter))
                    word.Append(letter);
            
            var candidate = word.ToString();
            if (!string.IsNullOrWhiteSpace(candidate) && !banned.Contains(candidate))
            {
                map.TryAdd(candidate, 1);
                map[candidate] += 1;
            }
        }
        
        return map
            .OrderByDescending(i => i.Value)
            .FirstOrDefault()
            .Key
            .ToString();
    }
}