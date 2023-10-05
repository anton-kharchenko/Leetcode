public class Solution {
    public int MaxArea(int[] height) {
        var left = 0;
        var right = height.Length - 1;
        var ans = 0;
        
        while(left <right){
            var length = right - left;
            var minHeight = Math.Min(height[left], height[right]);
            var currentArrea = length * minHeight;
            
            ans = Math.Max(ans, currentArrea);
            
            if(height[left]< height[right]){
                left++;
            }else{
                right--;
            }
        }
        
        return ans;
    }
}