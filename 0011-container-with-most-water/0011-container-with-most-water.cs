public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int startArea = 0;
        int endArea = height.Length - 1;
        
        while(startArea<endArea){
            int length = endArea - startArea;
            int minHeight = Math.Min(height[startArea], height[endArea]);
            
            int currentArea = length * minHeight;
            maxArea = Math.Max(maxArea, currentArea);
            
            if(height[startArea] < height[endArea]){
                startArea += 1;
            }else{
                endArea -= 1;
            }
        }
        
        return maxArea; 
    }
}