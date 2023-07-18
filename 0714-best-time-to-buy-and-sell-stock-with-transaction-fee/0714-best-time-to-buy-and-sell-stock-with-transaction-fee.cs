public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        int buy = int.MinValue;
        int sell = 0;
        
        foreach(var price in prices){
            var nextBuy = Math.Max(buy, sell - (price + fee));
            var nextSell =  Math.Max(sell, buy + price);
            
            buy = nextBuy;
            sell = nextSell;
        }
        
        
        return sell;
    }
}