public class Solution 
{
public string NearestPalindromic(string n)
{
var input = Convert.ToInt64(n);
if (input <= 11)
return (input < 11 ? input - 1 : input - 2).ToString();
var spld = n.Substring(0, n.Length / 2 + n.Length % 2);
var Pld = n.Substring(0, n.Length / 2) + new string(spld.Reverse().ToArray());
var lowPld = Convert.ToInt64(Pld.ToString());
var upPld = Convert.ToInt64(Pld.ToString());

        if (upPld.ToString().Equals(n) || upPld < input)
        {
            var upnum = (Convert.ToInt64(spld) + 1).ToString();
            var upinc = upnum.Length > spld.Length ? n.Length % 2 + 1 : n.Length % 2;
            Pld = upnum + new string(upnum.Substring(0, upnum.Length - upinc).Reverse().ToArray());
            upPld = Convert.ToInt64(Pld.ToString());
        }
        if (lowPld.ToString().Equals(n) || lowPld > input)
        {
            var lownum = (Convert.ToInt64(spld) - 1).ToString();
            var lowinc = n.Length % 2;
            if (lownum.Length < spld.Length)
            {
                lownum = lownum + lownum.Last();
                lowinc = lowinc + 1;
            }
            Pld = lownum + new string(lownum.Substring(0, lownum.Length - lowinc).Reverse().ToArray());
            lowPld = Convert.ToInt64(Pld.ToString());
        }
        return (input - lowPld) <= (upPld - input) ? lowPld.ToString() : upPld.ToString();
}
}