public class Solution {
    public IList<IList<int>> Subsets(int[] nums)
    {
        var subsets = new List<IList<int>>();
        var candidate = new List<int>();
        var index = 0;
        Backtracking(nums, index, candidate, subsets);
        return subsets;
    }
    
    public void Backtracking(int[] nums, int index, List<int> candidate, List<IList<int>> subsets){
        if(index == nums.Length){
            subsets.Add(candidate.ToList());
            return;
        }
        
        candidate.Add(nums[index]);
        Backtracking(nums, index+1, candidate,  subsets);
        candidate.RemoveAt(candidate.Count - 1);
        Backtracking(nums, index+1, candidate,  subsets);
    }
    
}