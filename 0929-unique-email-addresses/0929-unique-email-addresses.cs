public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var list = new List<string>();
        
        foreach(var email in emails){
            var s = email.Split("@");
            var local = s[0];
            var domain = s[1];
            var temp = string.Empty;
            
            for(var i = 0; i<local.Length; i++){
                if(local[i] == '.') continue;
                if(local[i]=='+') break;
                temp += local[i];
            }
            
            list.Add(temp+"@"+domain);
        }
        
    var res =  list.Distinct();
    return res.Count();
        
    }
}