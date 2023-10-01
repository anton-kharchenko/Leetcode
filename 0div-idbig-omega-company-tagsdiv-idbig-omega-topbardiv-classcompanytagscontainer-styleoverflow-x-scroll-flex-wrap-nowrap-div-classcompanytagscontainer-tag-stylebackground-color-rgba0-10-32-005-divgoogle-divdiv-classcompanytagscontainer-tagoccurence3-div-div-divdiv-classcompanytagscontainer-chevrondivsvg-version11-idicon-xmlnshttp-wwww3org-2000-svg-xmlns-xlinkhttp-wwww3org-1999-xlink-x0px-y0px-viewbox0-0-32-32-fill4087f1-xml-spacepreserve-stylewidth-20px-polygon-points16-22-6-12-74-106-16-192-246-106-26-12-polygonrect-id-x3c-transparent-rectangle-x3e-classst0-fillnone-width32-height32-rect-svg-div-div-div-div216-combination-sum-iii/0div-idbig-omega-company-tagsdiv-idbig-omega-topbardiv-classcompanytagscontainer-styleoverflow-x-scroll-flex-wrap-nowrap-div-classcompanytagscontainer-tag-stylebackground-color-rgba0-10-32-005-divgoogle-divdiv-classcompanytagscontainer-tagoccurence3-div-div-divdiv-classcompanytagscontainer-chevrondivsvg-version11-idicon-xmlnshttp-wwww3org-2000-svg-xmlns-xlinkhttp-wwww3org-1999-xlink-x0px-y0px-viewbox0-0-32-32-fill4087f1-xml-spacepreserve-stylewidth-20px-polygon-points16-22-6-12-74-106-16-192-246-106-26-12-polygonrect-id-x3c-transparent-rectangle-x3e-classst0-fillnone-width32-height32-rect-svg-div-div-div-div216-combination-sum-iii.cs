public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        Dfs(result, new List<int>(), n, k, 1);
        return result;
    }
    
    public void Dfs(List<IList<int>> result, List<int> candidateCombination, int remains, int k, int index){
        
        if(remains < 0){
            return;
        }
        
        if(candidateCombination.Count == k && remains == 0){
            result.Add(candidateCombination.ToList());
            return;
        }
        
        for(var i = index; i<10; i++){
            candidateCombination.Add(i);
            Dfs(result, candidateCombination, remains - i, k, i+1);
            candidateCombination.RemoveAt(candidateCombination.Count - 1);  
        }

    }
}