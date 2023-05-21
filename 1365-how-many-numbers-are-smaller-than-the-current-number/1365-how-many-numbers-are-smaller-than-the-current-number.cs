public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var temporaryList = nums.ToList(); 
        
        var length = nums.Length; 
        
        var resultArray = new int[length]; 
        
        for(var i = 0; i < length; i++){ 
            
           var currentElement = nums[i];
            
           resultArray[i] = temporaryList.Count(element => element < currentElement); // Count All element that less than current 
            
        }
        
        return resultArray;
    }
}