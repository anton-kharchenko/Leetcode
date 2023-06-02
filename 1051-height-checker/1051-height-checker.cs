public class Solution {
    public int HeightChecker(int[] heights) {
        var expected = new int[heights.Length];
        
        Array.Copy(heights, expected, heights.Length);
        
        Array.Sort(expected); // O(n*logn)
        
        var result = 0;
        
        for(var i = 0; i<heights.Length; i++){ // O(n)
            if(heights[i] != expected[i]){
                result++;
            }
        }
        
        return result;
    }

}


// Time -  O(n log n)
// Space - O(n)