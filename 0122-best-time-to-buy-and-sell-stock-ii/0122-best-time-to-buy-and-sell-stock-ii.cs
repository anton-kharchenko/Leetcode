public class Solution {
    public int MaxProfit(int[] prices) {
        var total = 0;
        
        for(var i =1; i<prices.Length; i++){
            if(prices[i] > prices[i-1]){
                total +=  prices[i] - prices[i-1];
            }
        }
        
        return total;
    }
}