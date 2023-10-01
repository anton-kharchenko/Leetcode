public class Solution {
    public int SubsetXORSum(int[] nums) {
        var allCombinations = new List<IList<int>>();
        var subSet = new List<int>();
        var result = 0;
        Dfs(nums, 0, subSet, allCombinations);
        
        foreach(var combination in allCombinations){
            var temp = 0;
            foreach(var numb in combination){
                temp ^= numb;
            }
            result += temp;
        }
        
        return result;
    }
    
    public void Dfs(int []nums, int index, List<int>subSet, List<IList<int>> allCombinations){
        if(index == nums.Length){
            allCombinations.Add(subSet.ToList());
            return;
        }
        
        subSet.Add(nums[index]);
        Dfs(nums, index + 1, subSet, allCombinations);
        subSet.RemoveAt(subSet.Count-1);
        Dfs(nums, index + 1, subSet, allCombinations);
    }
}