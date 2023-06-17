public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> comb = new List<int>();
        CombSum(result, comb, target, 0, 0, candidates);
        return result;
    }
    
    public void CombSum(List<IList<int>> result, List<int> comb, int target, int sum, int i, int[] candidates){
        if(sum>target) return;
        if(sum== target){ 
            result.Add(comb.ToList());
            return;
        }
        
        while(i<candidates.Length){
            sum += candidates[i];
            comb.Add(candidates[i]);
            CombSum(result, comb, target, sum, i, candidates);
            sum -= candidates[i];
            comb.RemoveAt(comb.Count - 1);
            i++;
        }
    }

}

