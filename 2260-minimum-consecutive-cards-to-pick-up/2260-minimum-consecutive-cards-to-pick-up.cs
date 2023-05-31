public class Solution {
    public int MinimumCardPickup(int[] cards) {
        if(cards.Length < 2) return -1;
        int min = int.MaxValue;
        var dic = new Dictionary<int, int>();
        
        for(var i = 0; i<cards.Length; i++){
            var key = cards[i];
            if(!dic.ContainsKey(key)){
                dic.Add(key, i);
            }else{
                min = Math.Min(min, i -  dic[key] + 1);
                dic[key] = i;
            }
        }
        
        return min == int.MaxValue ? -1: min;
    }
}