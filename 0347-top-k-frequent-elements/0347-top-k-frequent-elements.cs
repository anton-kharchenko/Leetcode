public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
        var result = new int[k];
        
        
        foreach(var num in nums){
            if(dic.ContainsKey(num)){
                dic[num] += 1;
            }else{
                dic.Add(num, 1);
            }
        }
        
        var orderedDic = dic.OrderByDescending(n=>n.Value);
        var index = 0;
        
        foreach(var (key, _) in orderedDic){
            if(index<k){
                result[index++] = key;
            }
            
            if(index == k) break;
            
        
        }
        
        return result;
    }
}