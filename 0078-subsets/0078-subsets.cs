public class Solution {
    public IList<IList<int>> Subsets(int[] nums)
    {
        var res = new List<IList<int>>();
        var subSet = new List<int>();
        Helper(0, res, subSet, nums);
        return res;
    }
    
    public void Helper(int index, List<IList<int>> res,  List<int> subSet, int[] nums){
        if(index >= nums.Length){
            res.Add(subSet.ToList());
            return;
        }
        
        subSet.Add(nums[index]);
        Helper(index+1, res, subSet, nums);
        subSet.Remove(nums[index]);
        Helper(index+1, res, subSet, nums);
    }
}