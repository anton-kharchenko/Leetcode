public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        
        
    var res = new List<IList<int>>();
    
    res.Add(new List<int>(){1});    
    
    for(var i = 1; i<numRows; i++){
        
        var temp = new List<int>();
        
        for(var j = 0; j<=i; j++ ){
            
            if(j ==0 || j == i){
                temp.Add(1);
            }else{
                temp.Add(res[i-1][j-1] + res[i-1][j]);
            }
        }
        
        res.Add(temp);
        
    }    
        
    return res;
    }
}