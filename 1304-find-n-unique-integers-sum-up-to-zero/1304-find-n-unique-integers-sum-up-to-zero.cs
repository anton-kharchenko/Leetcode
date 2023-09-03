public class Solution {
    public int[] SumZero(int n) {
        var res = new List<int>();
        if(n % 2== 1){
            res.Add(0);
            n--;
        }
        for(var i = 1; i<=n/2;i++){
            res.Add(i);
            res.Add(-i);
        }
        return res.ToArray();
    }
}