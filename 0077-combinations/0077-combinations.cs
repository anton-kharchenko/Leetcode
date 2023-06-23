public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var res = new List<IList<int>>();
        Helper(res, new List<int>(), n, k, 1);
        return res;
    }
    
    public void Helper(List<IList<int>> res, List<int> subSet, int n, int k, int number){
        if(subSet.Count==k){
            res.Add(subSet.ToList());
            return;
        }
        if(number > n) return;
        
        subSet.Add(number);
        Helper(res, subSet, n, k, number+1);
        subSet.Remove(number);
        Helper(res, subSet, n, k, number+1);
    }
}