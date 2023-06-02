public class Solution {
    public int HeightChecker(int[] heights) {
        var expected = new int[heights.Length];
        
        Array.Copy(heights, expected, heights.Length);// O(n)
        
        Array.Sort(expected); // O(n* log n)
        
        
        var result = 0;
        for(var i = 0; i<heights.Length; i++){ // O(n)
              
            if(heights[i] != expected[i]){
                result++;
            }
        }
        return result;
    }

}

// Time: O(n) + O(n* log n) +  O(n) = O(n* log n)
// Space: O(n)


