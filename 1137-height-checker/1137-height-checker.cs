public class Solution {
    public int HeightChecker(int[] heights) {
        var current = heights.ToList();  
        Array.Sort(heights);
        var expected = heights; 
        var result = 0;
        for(var i = 0; i<heights.Length; i++){
            if(current[i] != expected[i]){
                result += 1;
            }
        }
        return result;
    }
}