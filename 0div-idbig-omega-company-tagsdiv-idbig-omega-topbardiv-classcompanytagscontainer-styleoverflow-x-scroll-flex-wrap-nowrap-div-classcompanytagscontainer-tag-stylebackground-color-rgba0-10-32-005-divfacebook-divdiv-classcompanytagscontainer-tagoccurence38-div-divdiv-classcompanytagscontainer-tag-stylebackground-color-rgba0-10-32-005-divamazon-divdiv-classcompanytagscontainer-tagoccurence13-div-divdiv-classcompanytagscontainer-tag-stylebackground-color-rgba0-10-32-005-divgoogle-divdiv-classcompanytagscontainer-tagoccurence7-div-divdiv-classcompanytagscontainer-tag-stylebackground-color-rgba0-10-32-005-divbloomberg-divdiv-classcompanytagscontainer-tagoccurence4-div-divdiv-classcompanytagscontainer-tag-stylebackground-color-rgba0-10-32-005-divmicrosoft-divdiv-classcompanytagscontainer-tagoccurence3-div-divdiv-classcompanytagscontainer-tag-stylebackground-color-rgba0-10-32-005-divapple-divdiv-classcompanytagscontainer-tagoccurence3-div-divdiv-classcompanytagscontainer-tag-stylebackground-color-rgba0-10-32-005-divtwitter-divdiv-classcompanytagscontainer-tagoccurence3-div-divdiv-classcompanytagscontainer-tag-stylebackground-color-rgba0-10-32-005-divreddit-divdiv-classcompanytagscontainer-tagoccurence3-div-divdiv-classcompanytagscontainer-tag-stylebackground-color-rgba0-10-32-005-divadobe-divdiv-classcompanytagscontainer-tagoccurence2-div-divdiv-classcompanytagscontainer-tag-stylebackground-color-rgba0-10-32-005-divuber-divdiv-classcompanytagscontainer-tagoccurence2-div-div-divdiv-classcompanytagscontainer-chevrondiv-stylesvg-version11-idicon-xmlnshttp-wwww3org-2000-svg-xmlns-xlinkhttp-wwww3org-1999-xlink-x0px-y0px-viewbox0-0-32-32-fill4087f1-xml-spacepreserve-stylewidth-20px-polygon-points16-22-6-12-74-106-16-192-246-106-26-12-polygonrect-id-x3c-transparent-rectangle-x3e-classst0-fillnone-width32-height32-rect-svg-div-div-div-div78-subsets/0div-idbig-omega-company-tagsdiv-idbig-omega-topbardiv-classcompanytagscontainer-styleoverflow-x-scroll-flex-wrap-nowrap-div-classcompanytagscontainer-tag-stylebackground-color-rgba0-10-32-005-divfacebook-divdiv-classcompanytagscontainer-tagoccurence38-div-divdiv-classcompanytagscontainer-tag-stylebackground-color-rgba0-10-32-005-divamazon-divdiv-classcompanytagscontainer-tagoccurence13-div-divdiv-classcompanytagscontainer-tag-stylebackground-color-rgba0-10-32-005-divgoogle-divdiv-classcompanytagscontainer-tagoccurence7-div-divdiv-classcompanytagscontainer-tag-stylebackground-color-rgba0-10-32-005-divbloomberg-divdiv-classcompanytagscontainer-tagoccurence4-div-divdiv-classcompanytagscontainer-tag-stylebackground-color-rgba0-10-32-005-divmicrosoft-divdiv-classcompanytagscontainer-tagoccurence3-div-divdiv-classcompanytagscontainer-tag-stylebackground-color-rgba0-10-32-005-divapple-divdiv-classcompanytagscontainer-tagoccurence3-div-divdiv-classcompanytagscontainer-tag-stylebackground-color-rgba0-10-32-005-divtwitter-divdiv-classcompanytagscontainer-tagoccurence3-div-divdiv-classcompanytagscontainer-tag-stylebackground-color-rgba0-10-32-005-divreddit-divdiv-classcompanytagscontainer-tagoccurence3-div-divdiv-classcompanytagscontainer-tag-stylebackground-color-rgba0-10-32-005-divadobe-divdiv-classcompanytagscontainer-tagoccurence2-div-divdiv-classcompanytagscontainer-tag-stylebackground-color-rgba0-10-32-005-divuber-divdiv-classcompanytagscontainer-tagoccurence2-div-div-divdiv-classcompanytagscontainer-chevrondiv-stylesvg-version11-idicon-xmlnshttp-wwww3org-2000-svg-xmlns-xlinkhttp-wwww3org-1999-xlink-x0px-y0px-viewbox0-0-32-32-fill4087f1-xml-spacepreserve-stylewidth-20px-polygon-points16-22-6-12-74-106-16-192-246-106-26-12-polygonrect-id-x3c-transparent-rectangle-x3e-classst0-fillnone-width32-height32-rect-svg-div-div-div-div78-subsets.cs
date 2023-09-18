public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    List<int> subset = new List<int>();
    public IList<IList<int>> Subsets(int[] nums)
    {
        Dfs(0, nums);
        return res;
    }
    
    public void Dfs(int index, int[] nums){
        if(index == nums.Length){
            res.Add(subset.ToList());
            return;
        }
        
        subset.Add(nums[index]);
        Dfs(index + 1, nums);
        subset.Remove(nums[index]);
        Dfs(index + 1, nums);
    }
}