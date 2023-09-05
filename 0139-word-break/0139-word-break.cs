public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var q = new Queue<string>();
        var visited = new HashSet<string>();
        q.Enqueue(s);
        
        while(q.Count> 0){
            var curr = q.Dequeue();
            if(string.IsNullOrEmpty(curr))
                return true;
            
            foreach(var word in wordDict){
                if(curr.StartsWith(word)){
                    var sub = curr.Substring(word.Length);
                    
                    if(string.IsNullOrEmpty(sub))
                         return true;
                    
                    if(!visited.Contains(sub)){
                        q.Enqueue(sub);
                        visited.Add(sub);
                    }
                }
            }
        }
        
        return false;
    }


}