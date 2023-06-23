public class Solution {
    List<IList<int>> res;
    int length;
    Dictionary<int, int> dict;
    
    public IList<IList<int>> PermuteUnique(int[] nums) {
        res = new List<IList<int>>();
        length = nums.Length;
        var subSet = new List<int>();
        dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; ++i) {
            if (!dict.ContainsKey(nums[i])) {
                dict.Add(nums[i], 0);
            }
            
            dict[nums[i]] += 1;
        }
        
        Backtraking(subSet);
        
        return res;
    }
    
    public void Backtraking(List<int> subSet){
        
        if(length == subSet.Count){
            res.Add(new List<int>(subSet));
            return;
        }
        
        foreach(var (key, value) in dict){
            if(value != 0){
                subSet.Add(key);
                dict[key]--;
                
                Backtraking(subSet);
                
                subSet.RemoveAt(subSet.Count - 1); 
                dict[key]++;
               
            }else{
                continue;
            }
        }
    }
}