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
        
        var sortedDictionary = dic.OrderByDescending(i=>i.Value);
        
        var index = 0;
       
        foreach(var (key, _) in sortedDictionary){
            if(index < k){
                result[index] = key;
            }
            if(index == k) break;
            index++;
        }
        
        return result;
    }
}