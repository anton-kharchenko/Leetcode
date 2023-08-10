public class Solution {
    public int Change(int amount, int[] coins) {
        int[] d = new int[amount + 1];
	    d[0] = 1;

	foreach(var coin in coins) // Go through all exists coins
	{
		for(int a = coin; a <= amount; a++) // Calculate for every coin posible ways 
		{                
			d[a] += d[a - coin];            // 5                      
		}
	}

	return d[amount];
    }
    
 
}