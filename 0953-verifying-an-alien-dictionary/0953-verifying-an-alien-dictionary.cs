public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var dict = new Dictionary<char, int>();
      
        for(int i = 0; i < order.Length; i++) {
            dict.Add(order[i], i);
        }
        
        
        for(var i = 0; i<words.Length -1; i++){
            for(var j =0; j<words[i].Length; j++){
                if(j>=words[i+1].Length) return false;
                if (dict[words[i][j]] > dict[words[i + 1][j]])
                    return false;
                if (dict[words[i][j]] < dict[words[i + 1][j]])
                    break;
            }
        }
        
        return true;
    }
}