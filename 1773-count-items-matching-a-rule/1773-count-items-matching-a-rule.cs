public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) =>
        
         items.Count(x=>
                             (ruleKey == "type" && x[0] == ruleValue)
                          || (ruleKey == "color" && x[1] == ruleValue)
                          || (ruleKey == "name" && x[2] == ruleValue)
                          );
        
    
}