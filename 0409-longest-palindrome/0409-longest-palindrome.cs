public class Solution {
    public int LongestPalindrome(string s) {
        var dict = new Dictionary<char, int>();
        foreach (var letter in s)
        {
            dict.TryAdd(letter, 0);
            dict[letter] += 1;
        }

        var result = 0;
        foreach (var (letter, count) in dict)
        {
            if (count % 2 == 0)
            {
                result += count;
            }else
            {
                if (count > 2)
                {
                    result += count - 1;
                }
            }
        }

        if (dict.Values.Any(i => i % 2 == 1))
            result += 1;
        return result;
    }
}