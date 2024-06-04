public class Solution {
    public int LongestPalindrome(string s) {
        var count = 0;
        var set = new HashSet<char>();

        foreach (var i in s)
        {
            if (set.Contains(i))
            {
                count++;
                set.Remove(i);
            }
            else
            {
                set.Add(i);
            }
        }

        if (count < 1)
        {
            return 1;
        }

        if (s.Length > count * 2)
        {
            return count * 2 + 1;
        }

        return count * 2;
    }
}