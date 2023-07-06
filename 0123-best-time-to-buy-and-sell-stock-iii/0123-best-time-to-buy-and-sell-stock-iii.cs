public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0) return 0;
        int firstBuy = int.MinValue;
        int secondBuy = int.MinValue;
        int firstSell = 0;
        int secondSell = 0;
        
        for(var i = 0; i<prices.Length; i++){
            firstBuy =  Math.Max(firstBuy, -prices[i]);
            firstSell = Math.Max(firstSell, firstBuy + prices[i]);
            secondBuy =  Math.Max(secondBuy, firstSell-prices[i]);
            secondSell = Math.Max(secondSell, secondBuy + prices[i]);
        }
        
        return secondSell;
    }
}