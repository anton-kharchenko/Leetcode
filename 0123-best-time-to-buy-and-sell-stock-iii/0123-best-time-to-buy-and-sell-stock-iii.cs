public class Solution {
    public int MaxProfit(int[] prices) {
    if(prices.Length == 0) return 0;
    int firstBuy = int.MinValue, secondBuy = int.MinValue, firstSell = 0, secondSell = 0;
    foreach (var price in prices)
    {
        firstBuy =  Math.Max(firstBuy, -price); 
        firstSell = Math.Max(firstSell, firstBuy + price); 
        secondBuy =  Math.Max(secondBuy, firstSell-price); 
        secondSell = Math.Max(secondSell, secondBuy + price); 
    }
    return secondSell;
    }
}