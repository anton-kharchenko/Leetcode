public class Solution {
    public int HeightChecker(int[] heights) {

        var expected =  heights.ToList();
        
        expected.Sort();
        
        var count = 0;
        
        for(var i =0; i<heights.Length; i++){
            if(heights[i] != expected[i]){
                count++;
            }
        }
        
        return count;
        
    }
}