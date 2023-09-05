public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var q = new Queue<string>();
        var hs = new HashSet<string>();
        
        q.Enqueue(s);
        
        while(q.Count>0){
            var curr = q.Dequeue();
            if(string.IsNullOrEmpty(curr))
                return true;
            
            foreach(var word in wordDict){
                if(curr.StartsWith(word)){
                    var sb = curr.Substring(word.Length);
                    if(!hs.Contains(sb)){
                        q.Enqueue(sb);
                        hs.Add(sb);
                    }

                }
                
            }
            
        }
        
        return false;
    }


}

// leetcode - leet