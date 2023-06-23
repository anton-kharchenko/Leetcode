public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = new List<IList<int>>();
        CombSum(result,  new List<int>(), target, 0, 0, candidates);
        return result;
    }
    
    public void CombSum(List<IList<int>> result, List<int> comb,
                        int target, int sum, int index, int[] candidates){
        
        if(sum>target) return;
        if(sum== target){ 
            result.Add(comb.ToList());
            return;
        }
        
        while(index<candidates.Length){
            sum += candidates[index];
            comb.Add(candidates[index]);
            CombSum(result, comb, target, sum, index, candidates);
            sum -= candidates[index];
            comb.Remove(candidates[index]);
            index++;
        }
    }

}

