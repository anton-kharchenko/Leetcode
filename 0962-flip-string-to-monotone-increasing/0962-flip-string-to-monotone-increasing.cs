public class Solution {
    public int MinFlipsMonoIncr(string s) {
        var diff = new int[s.Length];
        var prev = 0;
        var cache = new int[s.Length];
        for(var i = s.Length - 1; i>=0; i--){
            diff[i] = prev;
            if(s[i] == '0'){
                diff[i] += 1;
            }

            prev =   diff[i];
        }

        return Recursion(s, 0, diff, cache);
    }

    public int Recursion(string s, int index, int[] diff, int[] cache){
        if(index == s.Length){
            return 0;
        }

        if(cache[index] != 0 ){
            return cache[index];
        }

        if(s[index] == '0'){
            cache[index] = Math.Min(Recursion(s, index + 1, diff, cache), diff[index]);
        }else{
            cache[index] = Math.Min(1 + Recursion(s, index + 1, diff, cache), diff[index]);
        }

        return cache[index];
    }
}