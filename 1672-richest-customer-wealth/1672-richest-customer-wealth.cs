public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var list = new List<int>();
        
        foreach(var account in accounts){
            list.Add(account.Sum());   
        }
        
        return list.Max();
    }
}