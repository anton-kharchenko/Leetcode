public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var k = nums.Length / 3;
        var dict = new Dictionary<int, int>();
        var ans = new List<int>();
        
        foreach(var num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }else{
                dict.Add(num, 1);
            }
        }
        
        foreach(var (key, value) in dict){
            if(value> k){
                ans.Add(key);
            }
        }
        
        return ans;
    }
}