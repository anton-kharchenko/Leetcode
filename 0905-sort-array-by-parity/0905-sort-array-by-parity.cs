public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        
        var oddNumbers = new List<int>();
        var evenNumbers = new List<int>();
        
        foreach(var i in nums){
            if(i%2==0){
                oddNumbers.Add(i);
            }else{
                evenNumbers.Add(i);
            }
        }
        
        var count = 0;
        foreach(var i in oddNumbers){
            nums[count++] = i;
        }
    
        foreach(var i in evenNumbers){
            nums[count++] = i;
        }
        
        return nums;
    }
}