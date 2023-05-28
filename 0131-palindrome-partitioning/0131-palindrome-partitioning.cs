public class Solution {
    List<IList<string>>  res = new  List<IList<string>>();
    public IList<IList<string>> Partition(string s) {
        
        Backtraking(s, 0, new List<string>());
        return res;
    }
    
    public void Backtraking(string s, int start, List<string> curr){
        if(s.Length == start){
            res.Add(new List<string>(curr));
            return;
        }
        
        for(var i = start; i<s.Length; i++){
            if(IsValid(start, i, s)){
                curr.Add(s.Substring(start, i-start+1));
                Backtraking(s, i+1, curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }
        
    }
    
    public bool IsValid(int left, int right, string s){
        while(left<right){
            if(s[left++]!= s[right--]) return false;
        }
        
        return true;
    }
}