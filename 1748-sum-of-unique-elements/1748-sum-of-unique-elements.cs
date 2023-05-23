public class Solution {
    public int SumOfUnique(int[] nums) {
        var dic = new Dictionary<int, int>();
        
        foreach(var i in nums){
            if(dic.ContainsKey(i)){
                dic[i] += 1;
            }
            else{
                dic.Add(i, 1);
            }
        }
        
        var total = 0;
        
        foreach(var (key, value) in dic){
            if(value == 1){
                total += key;
            }
        }
        
        return total;
    }
}