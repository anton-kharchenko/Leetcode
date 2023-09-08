public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var ans = new List<IList<int>>();
        ans.Add(new List<int>(){1});
        
        
        for(var i = 1; i<numRows; i++){
            var temp = new List<int>();
            for(var j = 0; j<= i; j++){
                if(j==0 || j==i){
                    temp.Add(1);
                }else{
                    temp.Add(ans[i-1][j-1] + ans[i-1][j]);
                }
            }
            
            ans.Add(temp);
        }
        
        return ans;
    }
}