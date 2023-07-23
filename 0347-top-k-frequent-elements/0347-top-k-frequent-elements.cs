public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        
        foreach(var n in nums){
            if(dict.ContainsKey(n)){
                dict[n]++;
            }else{
                dict.Add(n, 1);
            }
        }
        
        return dict.OrderByDescending(i=>i.Value).Take(k).Select(i=>i.Key).ToArray();
    }
}