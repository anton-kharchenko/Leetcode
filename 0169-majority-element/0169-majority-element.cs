public class Solution {
    public int MajorityElement(int[] nums) {
       var dic = new Dictionary<int, int>();
        
	for(var i = 0; i<nums.Length; i++){
      	   if(dic.ContainsKey(nums[i])){
         dic[nums[i]] += 1; 
        }else{
         dic.Add(nums[i], 1);
        }
      }

	var result = 0;
      var maxValue = 0;
        
	foreach(var (key, value) in dic){
      if(value> maxValue){
         maxValue = value;
	   result = key;
        } 
     }

	return result;
 
    }
}