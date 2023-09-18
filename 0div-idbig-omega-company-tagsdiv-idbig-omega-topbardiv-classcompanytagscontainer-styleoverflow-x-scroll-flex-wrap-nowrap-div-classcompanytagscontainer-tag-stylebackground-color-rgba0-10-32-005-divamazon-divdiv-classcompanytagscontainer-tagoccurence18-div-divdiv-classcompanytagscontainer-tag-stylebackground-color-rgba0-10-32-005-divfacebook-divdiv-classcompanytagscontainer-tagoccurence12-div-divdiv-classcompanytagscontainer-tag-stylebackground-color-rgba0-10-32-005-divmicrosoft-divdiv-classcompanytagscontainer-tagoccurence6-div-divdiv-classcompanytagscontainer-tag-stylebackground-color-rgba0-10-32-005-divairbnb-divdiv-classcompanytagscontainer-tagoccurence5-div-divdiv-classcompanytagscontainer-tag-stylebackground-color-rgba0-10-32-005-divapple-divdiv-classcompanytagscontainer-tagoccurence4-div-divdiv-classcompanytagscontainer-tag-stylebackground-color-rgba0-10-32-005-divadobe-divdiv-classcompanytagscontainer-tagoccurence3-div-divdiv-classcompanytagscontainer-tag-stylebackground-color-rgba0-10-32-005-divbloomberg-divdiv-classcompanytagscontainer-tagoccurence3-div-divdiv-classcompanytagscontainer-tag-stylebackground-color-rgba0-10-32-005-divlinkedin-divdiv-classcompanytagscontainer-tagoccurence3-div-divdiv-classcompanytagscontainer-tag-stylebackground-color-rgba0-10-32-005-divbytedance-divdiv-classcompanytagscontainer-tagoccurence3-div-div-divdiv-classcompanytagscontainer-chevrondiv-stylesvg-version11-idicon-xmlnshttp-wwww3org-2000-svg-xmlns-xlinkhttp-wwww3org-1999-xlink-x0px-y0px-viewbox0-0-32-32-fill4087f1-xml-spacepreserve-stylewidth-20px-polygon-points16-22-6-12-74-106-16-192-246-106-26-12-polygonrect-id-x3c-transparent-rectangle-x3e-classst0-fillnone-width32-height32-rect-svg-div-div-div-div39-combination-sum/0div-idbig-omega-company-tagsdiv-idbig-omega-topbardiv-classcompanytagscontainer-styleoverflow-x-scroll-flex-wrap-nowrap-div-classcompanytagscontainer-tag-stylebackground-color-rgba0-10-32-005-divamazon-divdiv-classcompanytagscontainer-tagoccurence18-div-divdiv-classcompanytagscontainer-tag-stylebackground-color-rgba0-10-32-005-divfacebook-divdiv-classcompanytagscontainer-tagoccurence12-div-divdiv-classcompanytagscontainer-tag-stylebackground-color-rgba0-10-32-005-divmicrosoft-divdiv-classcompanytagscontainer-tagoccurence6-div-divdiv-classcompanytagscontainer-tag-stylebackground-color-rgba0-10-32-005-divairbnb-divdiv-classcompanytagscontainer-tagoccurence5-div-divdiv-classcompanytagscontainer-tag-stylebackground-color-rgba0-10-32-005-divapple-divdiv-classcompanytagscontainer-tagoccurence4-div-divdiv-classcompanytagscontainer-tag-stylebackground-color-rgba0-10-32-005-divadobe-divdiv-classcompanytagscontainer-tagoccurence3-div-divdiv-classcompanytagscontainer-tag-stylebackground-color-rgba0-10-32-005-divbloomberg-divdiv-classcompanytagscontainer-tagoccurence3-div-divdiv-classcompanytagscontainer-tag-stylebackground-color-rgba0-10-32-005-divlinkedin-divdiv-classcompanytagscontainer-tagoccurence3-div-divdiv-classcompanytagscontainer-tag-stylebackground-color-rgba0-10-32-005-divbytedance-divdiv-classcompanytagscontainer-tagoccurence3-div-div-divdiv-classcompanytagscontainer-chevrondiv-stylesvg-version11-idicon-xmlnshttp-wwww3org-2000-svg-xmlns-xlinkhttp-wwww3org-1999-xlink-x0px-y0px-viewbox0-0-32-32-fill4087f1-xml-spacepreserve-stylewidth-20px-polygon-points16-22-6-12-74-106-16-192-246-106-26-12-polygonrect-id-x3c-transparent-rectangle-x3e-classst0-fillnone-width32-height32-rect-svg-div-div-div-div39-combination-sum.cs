public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    List<int> sub = new List<int>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Dfs(target, 0, 0, candidates);
        return result;
    }
    
    public void Dfs(int target, int sum, int index, int [] candidates){
        if(sum > target) return;
        if(sum == target){
            result.Add(sub.ToList());
            return;
        }
        
        while(index< candidates.Length){
            sum += candidates[index];
            sub.Add(candidates[index]);
            Dfs(target, sum, index, candidates);
            sum -= candidates[index];
            sub.Remove(candidates[index]);
            index++;
        }
    }
    
}

