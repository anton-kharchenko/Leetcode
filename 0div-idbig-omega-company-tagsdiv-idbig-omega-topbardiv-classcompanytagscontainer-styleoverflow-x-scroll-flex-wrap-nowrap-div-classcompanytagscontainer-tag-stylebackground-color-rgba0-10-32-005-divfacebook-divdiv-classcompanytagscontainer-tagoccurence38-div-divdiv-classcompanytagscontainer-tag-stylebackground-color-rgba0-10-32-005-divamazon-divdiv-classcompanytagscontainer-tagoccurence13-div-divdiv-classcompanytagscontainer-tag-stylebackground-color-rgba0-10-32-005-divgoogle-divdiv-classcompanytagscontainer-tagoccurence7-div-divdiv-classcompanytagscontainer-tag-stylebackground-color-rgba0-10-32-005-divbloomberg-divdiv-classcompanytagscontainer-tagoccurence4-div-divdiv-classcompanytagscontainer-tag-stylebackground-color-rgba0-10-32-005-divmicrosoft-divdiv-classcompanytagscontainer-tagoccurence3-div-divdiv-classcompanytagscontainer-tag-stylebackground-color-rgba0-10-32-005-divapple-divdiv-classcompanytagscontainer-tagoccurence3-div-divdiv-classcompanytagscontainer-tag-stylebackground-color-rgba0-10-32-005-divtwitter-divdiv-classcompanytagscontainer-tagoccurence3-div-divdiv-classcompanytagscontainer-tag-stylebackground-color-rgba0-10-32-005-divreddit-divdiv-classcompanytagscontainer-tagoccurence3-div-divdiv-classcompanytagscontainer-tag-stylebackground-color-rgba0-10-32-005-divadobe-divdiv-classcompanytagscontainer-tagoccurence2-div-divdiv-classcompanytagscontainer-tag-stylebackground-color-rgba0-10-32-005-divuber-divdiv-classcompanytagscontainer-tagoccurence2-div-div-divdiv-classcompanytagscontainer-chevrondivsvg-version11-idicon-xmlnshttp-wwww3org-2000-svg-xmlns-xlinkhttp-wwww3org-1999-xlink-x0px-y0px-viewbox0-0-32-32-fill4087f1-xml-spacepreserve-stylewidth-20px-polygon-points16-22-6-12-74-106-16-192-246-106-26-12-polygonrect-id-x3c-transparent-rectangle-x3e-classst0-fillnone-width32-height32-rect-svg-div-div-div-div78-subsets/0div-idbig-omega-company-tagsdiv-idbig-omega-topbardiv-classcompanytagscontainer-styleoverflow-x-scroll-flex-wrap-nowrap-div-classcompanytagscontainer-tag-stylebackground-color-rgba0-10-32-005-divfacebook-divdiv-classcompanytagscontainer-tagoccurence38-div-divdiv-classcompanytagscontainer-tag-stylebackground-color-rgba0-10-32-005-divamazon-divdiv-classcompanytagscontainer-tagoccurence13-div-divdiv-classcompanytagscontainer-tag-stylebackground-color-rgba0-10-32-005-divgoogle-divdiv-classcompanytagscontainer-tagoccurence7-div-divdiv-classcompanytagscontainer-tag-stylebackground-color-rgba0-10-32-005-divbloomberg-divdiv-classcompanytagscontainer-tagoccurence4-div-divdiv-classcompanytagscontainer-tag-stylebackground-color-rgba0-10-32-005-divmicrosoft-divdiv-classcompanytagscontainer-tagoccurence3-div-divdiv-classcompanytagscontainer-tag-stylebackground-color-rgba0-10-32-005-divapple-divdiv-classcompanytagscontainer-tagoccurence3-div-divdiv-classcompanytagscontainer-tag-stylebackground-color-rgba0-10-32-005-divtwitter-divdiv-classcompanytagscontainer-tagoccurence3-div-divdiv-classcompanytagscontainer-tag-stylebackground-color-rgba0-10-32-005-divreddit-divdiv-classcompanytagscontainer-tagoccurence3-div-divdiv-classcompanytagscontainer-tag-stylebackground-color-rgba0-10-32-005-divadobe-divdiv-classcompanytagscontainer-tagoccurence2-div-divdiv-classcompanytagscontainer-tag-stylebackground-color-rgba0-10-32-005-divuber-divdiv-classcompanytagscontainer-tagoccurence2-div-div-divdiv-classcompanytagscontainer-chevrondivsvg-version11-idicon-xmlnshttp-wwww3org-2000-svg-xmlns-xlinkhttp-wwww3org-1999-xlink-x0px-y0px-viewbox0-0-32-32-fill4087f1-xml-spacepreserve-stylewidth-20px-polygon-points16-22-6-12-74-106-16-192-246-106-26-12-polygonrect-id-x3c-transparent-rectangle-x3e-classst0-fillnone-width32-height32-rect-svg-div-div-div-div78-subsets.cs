public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    List<int> sub = new List<int>();
    public IList<IList<int>> Subsets(int[] nums)
    {
        
        Dfs(0, nums);
        return res;
    }
    
    public void Dfs(int index, int[] nums){
        if(index == nums.Length){
            res.Add(sub.ToList());
            return;
        }
        
        sub.Add(nums[index]);
        Dfs(index + 1, nums);
        sub.Remove(nums[index]);
        Dfs(index + 1, nums);
    }
}