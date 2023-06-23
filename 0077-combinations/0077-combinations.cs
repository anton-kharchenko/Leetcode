public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var res = new List<IList<int>>();
        Helper(res, new List<int>(), n, k, 1);
        return res;
    }
    
    public void Helper(List<IList<int>> res, List<int> subSet, int n, int k, int index){
        if(subSet.Count==k){
            res.Add(subSet.ToList());
            return;
        }
        if(index > n) return;
        
        subSet.Add(index);
        Helper(res, subSet, n, k, index+1);
        subSet.Remove(index);
        Helper(res, subSet, n, k, index+1);
    }
}