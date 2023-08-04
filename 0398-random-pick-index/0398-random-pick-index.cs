public class Solution {
    Dictionary<int,  List<int>> dict = new  Dictionary<int,  List<int>>();
    public Solution(int[] nums) {
        var index = 0;
        foreach(var n in nums){
            if(dict.ContainsKey(n)){
               dict[n].Add(index);
                index++;
            }else{
                dict.Add(n, new List<int>(){index});
                index++;
            }

        }
    }
    
    public int Pick(int target) {
        var list = dict[target];
        if(list.Count == 1){
            return list[0];
        }
        
        var size = list.Count;
        var rnd = new Random().Next(0, size);
        return list[rnd];
        
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */