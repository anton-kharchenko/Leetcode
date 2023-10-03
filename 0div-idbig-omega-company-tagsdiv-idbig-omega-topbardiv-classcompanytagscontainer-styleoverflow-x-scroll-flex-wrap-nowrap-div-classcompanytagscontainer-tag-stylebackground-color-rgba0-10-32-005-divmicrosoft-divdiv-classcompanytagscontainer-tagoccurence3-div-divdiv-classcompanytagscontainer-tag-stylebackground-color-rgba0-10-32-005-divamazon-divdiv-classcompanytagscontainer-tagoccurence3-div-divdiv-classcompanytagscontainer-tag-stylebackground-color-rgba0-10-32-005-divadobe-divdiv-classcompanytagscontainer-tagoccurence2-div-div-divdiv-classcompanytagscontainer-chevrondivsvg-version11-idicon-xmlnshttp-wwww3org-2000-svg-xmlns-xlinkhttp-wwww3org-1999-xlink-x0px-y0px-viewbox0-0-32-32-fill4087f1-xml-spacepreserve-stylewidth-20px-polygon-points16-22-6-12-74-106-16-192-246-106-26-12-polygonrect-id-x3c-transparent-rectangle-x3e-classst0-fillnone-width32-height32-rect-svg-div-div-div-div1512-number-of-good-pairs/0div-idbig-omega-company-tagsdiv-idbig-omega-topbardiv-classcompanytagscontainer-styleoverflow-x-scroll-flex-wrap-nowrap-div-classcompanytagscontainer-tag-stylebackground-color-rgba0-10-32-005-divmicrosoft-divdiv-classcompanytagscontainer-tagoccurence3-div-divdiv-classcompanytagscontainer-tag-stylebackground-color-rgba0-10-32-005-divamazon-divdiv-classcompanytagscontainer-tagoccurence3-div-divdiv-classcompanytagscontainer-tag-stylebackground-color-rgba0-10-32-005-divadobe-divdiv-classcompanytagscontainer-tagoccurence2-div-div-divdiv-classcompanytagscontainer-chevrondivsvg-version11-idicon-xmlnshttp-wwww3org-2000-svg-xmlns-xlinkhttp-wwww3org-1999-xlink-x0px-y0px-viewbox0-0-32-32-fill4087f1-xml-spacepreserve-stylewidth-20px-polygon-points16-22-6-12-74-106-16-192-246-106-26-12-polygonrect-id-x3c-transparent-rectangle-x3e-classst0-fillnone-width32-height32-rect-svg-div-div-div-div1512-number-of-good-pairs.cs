public class Solution {
    public int NumIdenticalPairs(int[] nums) {
      var dictionary = new Dictionary<int, int>();
      foreach(var num in nums){
          if(dictionary.ContainsKey(num)){
              dictionary[num]++;
          }else{
              dictionary.Add(num, 1);
          }
      }
        var result = 0;
       foreach(var (key, value) in dictionary){
           if(value > 1){
               result += CountGooPairs(value - 1);
           }
       } 
        
        return result;
    }
    
    public int CountGooPairs(int num){
        var res = 0;
        for(var i = 1; i<=num; i++){
            res += i;
        }
        return res;
    }
}