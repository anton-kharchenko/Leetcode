public class Solution {
    public int MinSwaps(string s) {
        int max = 0,  count = 0;
        foreach(var c in s){
            if(c == '['){
                count -= 1;
            }else{
                count += 1;
            }
            max = Math.Max(max, count);
        }
        var res = (max + 1) / 2;
        return res;
    }
}