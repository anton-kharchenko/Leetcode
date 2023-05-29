public class Solution {
    public int HammingWeight(uint n) {
        return Convert.ToString(n, 2).Replace("0", "").Length;
    }
}