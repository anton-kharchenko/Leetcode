public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        
        var n = citations.Length;
        var left = 0;
        var right = n - 1;
        
        while(left <= right){
            
            int mid = (left + right) / 2;
            
            if(citations[mid] == n - mid){
                return n - mid;
            }
            
            if(citations[mid] > n - mid)
              right = mid - 1;
            else
              left = mid + 1;
        }
        
        return n - left;

    }
}

// 0,1,2,5,6