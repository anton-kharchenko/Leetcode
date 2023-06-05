public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var dic = new Dictionary<char, int>(){
            {'b', 0},
            {'a', 0},
            {'l', 0},
            {'o', 0},
            {'n', 0},
        };
        
        foreach(var i in text){
            if(dic.ContainsKey(i)){
                dic[i] += 1;
            } 
        }
        
        int res=0;
        
        while(
            dic.Any(i=>i.Key == 'b' && i.Value >= 1) &&
            dic.Any(i=>i.Key == 'a' && i.Value >= 1) &&
            dic.Any(i=>i.Key == 'l' && i.Value >= 2) &&
            dic.Any(i=>i.Key == 'o' && i.Value >= 2) &&
            dic.Any(i=>i.Key == 'n' && i.Value >= 1)
             ){
            res++;
            dic['b'] -=1;
            dic['a'] -=1;
            dic['l'] -=2;
            dic['o'] -=2;
            dic['n'] -=1;

        }
      
        
        return res;
        
    }
}