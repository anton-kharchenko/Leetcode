public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
    
        foreach(var num in nums){
            if(dic.ContainsKey(num)){
                dic[num] += 1;
            }else{
                dic.Add(num, 1);
            }
        }
        
        return dic.OrderByDescending(i=>i.Value).Take(k).Select(i=>i.Key).ToArray();
    }
}