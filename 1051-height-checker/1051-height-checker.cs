public class Solution {
    public int HeightChecker(int[] heights) {

        var expected =  heights.ToList(); // O(n)
        
        expected.Sort(); // O(n log n)
        
        var count = 0;
        
        for(var i =0; i<heights.Length; i++){
            if(heights[i] != expected[i]){
                count++;
            }
        } // O (n)
        
        return count;
        
    }
    
    //Time: O(n log n)
    // Space O(2n) ~ O(n)
}