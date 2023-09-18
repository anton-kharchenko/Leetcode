public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var dict = new Dictionary<int, int>();
        
        for(var i = 0; i<mat.Length; i++){
            dict.Add(i, 0);
            for(var j = 0; j<mat[i].Length; j++){
                if(mat[i][j]==1){
                    dict[i]++;
                }
            }
        }
        
        var keys = dict.OrderBy(i=>i.Value).Select(i=>i.Key).ToArray();
        var ans = new int[k];
        
        for(var i = 0; i<k; i++){
            ans[i] = keys[i];
        }
        
        return ans;
    }
}