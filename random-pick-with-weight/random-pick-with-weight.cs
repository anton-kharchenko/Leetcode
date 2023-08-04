public class Solution {
    int[] weight;
    Random _rnd = new  Random();
    public Solution(int[] w) {
        weight = new int[w.Length];
        var max = 0;
        for(var i = 0; i<w.Length; i++){
            max += w[i];
            weight[i] = max; 
        }
        
    }
    
    public int PickIndex() {
        var index = _rnd.Next(0, weight[^1]) + 1;
        var res = Array.BinarySearch(weight, index);
        return res >= 0 ? res : - res -1;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */