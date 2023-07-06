public class Solution {
    public int TotalFruit(int[] fruits) {
    var dict = new Dictionary<int, int>();
    int res =0, l=0, total =0;
        
    foreach (var fruit in fruits)
    {
        if(dict.ContainsKey(fruit)){
            dict[fruit]++;
        }else{
            dict.Add(fruit, 1);
        }
               
        total += 1;
            
        while(dict.Count > 2){
                
            var left = fruits[l];
            dict[left]--;
            
            if(dict[left]<=0){
                dict.Remove(left);
            }
            
            total -= 1;
            l++;
        }
         
        
        res = Math.Max(res, total);
    }
        
    return res;
        
    }
}