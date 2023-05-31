public class Solution {
    public int MinimumCardPickup(int[] cards) {
        if(cards.Length < 2) return -1;
        var min = int.MaxValue;
        var dic = new Dictionary<int, int>();
        for(var i = 0; i<cards.Length; i++){
            if(!dic.ContainsKey(cards[i])){
                dic.Add(cards[i], i);
            }else{
                min = Math.Min(min, i -  dic[cards[i]] + 1);
                dic[cards[i]] = i;
            }
        }
        
        return min == int.MaxValue ? -1: min;
    }
}