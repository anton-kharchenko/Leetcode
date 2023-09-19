public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    List<int> sub = new List<int>();
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        Backtracking(0, nums);
        return res;
    }

    public void Backtracking(int index, int[] nums)
    {
        if (index == nums.Length)
        {
            res.Add(sub.ToList());
            return;
        }
        
        sub.Add(nums[index]);
        Backtracking(index + 1, nums);
        sub.Remove(nums[index]);

        while (index < nums.Length - 1 && nums[index] == nums[index + 1])
            index++;
        
        Backtracking(index + 1, nums);
    }
}