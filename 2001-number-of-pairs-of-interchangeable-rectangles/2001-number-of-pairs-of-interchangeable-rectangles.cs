public class Solution {
    public long InterchangeableRectangles(int[][] rectangles) {
    var dic = new Dictionary<double, long>();
    long res = 0;
        
        
    foreach(var i in rectangles)
    {
        var f = (double)i[0];
        var s = (double)i[1];
        var mid = f / s;
        if(!dic.ContainsKey(mid)){
            dic.Add(mid, 1);
        }else{
            dic[mid] += 1;
        }
    }
        
    foreach(var (key, value) in dic){
        if(value > 1){
            res += Calculate(value);
        }
    }
        
    return res;
    }
    
    public long Calculate(long number){
     number--;
     long res = 0;
     while (number != 0)
     {
         res += number;
         number--;
     }

     return res;
    }
}