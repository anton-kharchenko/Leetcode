public class Solution {
    public int LongestStrChain(string[] words) {
        HashSet<string> wordsAsHashSet = words.ToHashSet();
        Dictionary<string, int> dp = new();
        return words.Max(GetLongestChain);

        int GetLongestChain(string word)
            => 1 + Enumerable.Range(0, word.Length)
                    .Select(index => word[..index] + word[(index + 1)..])
                    .Where(predecessor => wordsAsHashSet.Contains(predecessor))
                    .Select(predecessor => dp.ContainsKey(predecessor) ? dp[predecessor] : dp[predecessor] = GetLongestChain(predecessor))
                    .Append(0)
                    .Max();
    }
}