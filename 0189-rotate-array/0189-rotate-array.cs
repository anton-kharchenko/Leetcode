public class Solution {
    public void Rotate(int[] nums, int k) {
   	var length = nums.Length;
    var arr = new int[length];
        
	Array.Copy(nums, arr, length);
        
    k %=  length;
        
	for(var index = 0; index<length; index++){
        nums[(index+k) % length] = arr[index];
    }

  }
}