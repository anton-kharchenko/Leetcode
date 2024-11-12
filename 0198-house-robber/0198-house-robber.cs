public class Solution {
    public int Rob(int[] houses) {
        var length = houses.Length;
        if (length == 1) return houses[0];
        if (length == 2) return Math.Max(houses[0], houses[1]);
        
        var total = new int[houses.Length];
        total[0] = houses[0];
        total[1] = Math.Max(houses[0], houses[1]);
        for (int i = 2; i < length; i++)
        {
            total[i] = Math.Max(total[i - 1], houses[i] + total[i - 2]);
        }
        
        return total[houses.Length - 1];
    }
}