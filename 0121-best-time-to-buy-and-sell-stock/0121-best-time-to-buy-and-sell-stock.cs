public class Solution {
    public int MaxProfit(int[] prices) {
        int ans = 0, min = prices[0];
        
        for(var i = 1; i<prices.Length; i++){
            var curr = prices[i];
            if(min<curr){
                ans = Math.Max(curr - min, ans);
                
            }else{
                min = curr;
            }
        }
        
        return ans;

    }
}