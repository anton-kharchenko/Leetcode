public class Solution {
    public List<IList<int>> res = new List<IList<int>>();
    public List<int> subSet = new List<int>();
    
    public IList<IList<int>> Subsets(int[] nums)
    {
        Dfs(nums, 0);
        return res;
    }
    
    public void Dfs(int[] nums, int index){
        if(index >= nums.Length){
            res.Add(subSet.ToList());
            return;
        }
        
        subSet.Add(nums[index]);
        Dfs(nums, index + 1);
        subSet.Remove(nums[index]);
        Dfs(nums, index + 1);
    }
    
}