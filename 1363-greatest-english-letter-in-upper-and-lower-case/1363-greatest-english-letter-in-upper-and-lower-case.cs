public class Solution
{
    public string GreatestLetter(string s)
    {
        var hs = new HashSet<char>();
        var letters = new HashSet<char>(s);
        var tempResult = new List<char>();

        foreach (var letter in letters)
        {
            var l = letter.ToString().ToLower()[0];

            if (!hs.Add(l))
            {
                tempResult.Add(letter);
            }
        }

        if (tempResult.Count == 0) return string.Empty;
        var result = tempResult[0];

        for (var i = 1; i < tempResult.Count; i++)
        {
            if (IsGreaterst(tempResult[i], result))
            {
                result = tempResult[i];
            }
        }

        return result.ToString().ToUpper();
    }

    private bool IsGreaterst(char a, char b)
    {
        return a % 32 > b % 32;
    }
}