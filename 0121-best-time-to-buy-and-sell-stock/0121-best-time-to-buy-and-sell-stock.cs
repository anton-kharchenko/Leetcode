public class Solution {
    public int MaxProfit(int[] prices)
    {
        var min = prices[0];
        var maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[i] - min);
            }
        }

        return maxProfit;
    }
}