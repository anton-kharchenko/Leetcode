public class Solution {
    public int FindNumbers(int[] nums) {
        var count = 0;
        
        foreach(var i in nums){
            if(i.ToString().Length % 2 == 0){
                count++;
            }
        }
        
        return count;
    }
}