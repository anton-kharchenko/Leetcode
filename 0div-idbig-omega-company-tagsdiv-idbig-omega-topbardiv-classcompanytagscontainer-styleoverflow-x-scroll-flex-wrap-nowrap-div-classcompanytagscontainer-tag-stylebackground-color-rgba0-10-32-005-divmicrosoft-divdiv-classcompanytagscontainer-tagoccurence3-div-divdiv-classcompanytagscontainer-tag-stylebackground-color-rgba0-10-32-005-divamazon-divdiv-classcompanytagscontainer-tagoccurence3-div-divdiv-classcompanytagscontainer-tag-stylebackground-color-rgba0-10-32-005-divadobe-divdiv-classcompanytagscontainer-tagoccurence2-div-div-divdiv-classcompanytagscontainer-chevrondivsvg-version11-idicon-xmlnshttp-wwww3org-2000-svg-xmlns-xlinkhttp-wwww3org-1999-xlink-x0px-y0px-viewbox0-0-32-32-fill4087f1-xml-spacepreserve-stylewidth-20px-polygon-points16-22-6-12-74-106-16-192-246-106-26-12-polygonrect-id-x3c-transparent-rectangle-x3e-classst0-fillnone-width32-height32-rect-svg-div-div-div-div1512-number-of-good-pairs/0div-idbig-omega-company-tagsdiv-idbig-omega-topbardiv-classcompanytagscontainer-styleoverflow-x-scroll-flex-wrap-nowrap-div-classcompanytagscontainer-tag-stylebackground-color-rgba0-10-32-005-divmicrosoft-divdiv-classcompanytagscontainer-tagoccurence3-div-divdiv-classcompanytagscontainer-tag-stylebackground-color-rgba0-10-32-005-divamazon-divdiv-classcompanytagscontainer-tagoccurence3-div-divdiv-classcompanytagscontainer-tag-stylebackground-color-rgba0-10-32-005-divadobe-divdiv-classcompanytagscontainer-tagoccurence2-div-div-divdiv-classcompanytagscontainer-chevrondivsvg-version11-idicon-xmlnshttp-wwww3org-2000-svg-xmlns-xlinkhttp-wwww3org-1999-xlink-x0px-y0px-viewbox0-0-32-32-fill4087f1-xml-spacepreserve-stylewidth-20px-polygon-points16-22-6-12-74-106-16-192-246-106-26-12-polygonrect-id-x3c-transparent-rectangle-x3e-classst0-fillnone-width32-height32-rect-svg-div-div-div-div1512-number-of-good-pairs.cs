public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var dictionary = new Dictionary<int, int>();
        var answer = 0;
        foreach(var num in nums){
            if(dictionary.ContainsKey(num))
            {
                dictionary[num]++;
            }else{
                dictionary.Add(num, 1);
            }
        }
        
        foreach(var (key, value) in dictionary){
               answer +=  CountGoodPairs(value);
        }
        
        return answer;
    }
    
    
    public int CountGoodPairs(int num){
        var result = 0;
        for(var i = 1; i< num; i++){
            result += i;
        }
        return result;
    }
    
}