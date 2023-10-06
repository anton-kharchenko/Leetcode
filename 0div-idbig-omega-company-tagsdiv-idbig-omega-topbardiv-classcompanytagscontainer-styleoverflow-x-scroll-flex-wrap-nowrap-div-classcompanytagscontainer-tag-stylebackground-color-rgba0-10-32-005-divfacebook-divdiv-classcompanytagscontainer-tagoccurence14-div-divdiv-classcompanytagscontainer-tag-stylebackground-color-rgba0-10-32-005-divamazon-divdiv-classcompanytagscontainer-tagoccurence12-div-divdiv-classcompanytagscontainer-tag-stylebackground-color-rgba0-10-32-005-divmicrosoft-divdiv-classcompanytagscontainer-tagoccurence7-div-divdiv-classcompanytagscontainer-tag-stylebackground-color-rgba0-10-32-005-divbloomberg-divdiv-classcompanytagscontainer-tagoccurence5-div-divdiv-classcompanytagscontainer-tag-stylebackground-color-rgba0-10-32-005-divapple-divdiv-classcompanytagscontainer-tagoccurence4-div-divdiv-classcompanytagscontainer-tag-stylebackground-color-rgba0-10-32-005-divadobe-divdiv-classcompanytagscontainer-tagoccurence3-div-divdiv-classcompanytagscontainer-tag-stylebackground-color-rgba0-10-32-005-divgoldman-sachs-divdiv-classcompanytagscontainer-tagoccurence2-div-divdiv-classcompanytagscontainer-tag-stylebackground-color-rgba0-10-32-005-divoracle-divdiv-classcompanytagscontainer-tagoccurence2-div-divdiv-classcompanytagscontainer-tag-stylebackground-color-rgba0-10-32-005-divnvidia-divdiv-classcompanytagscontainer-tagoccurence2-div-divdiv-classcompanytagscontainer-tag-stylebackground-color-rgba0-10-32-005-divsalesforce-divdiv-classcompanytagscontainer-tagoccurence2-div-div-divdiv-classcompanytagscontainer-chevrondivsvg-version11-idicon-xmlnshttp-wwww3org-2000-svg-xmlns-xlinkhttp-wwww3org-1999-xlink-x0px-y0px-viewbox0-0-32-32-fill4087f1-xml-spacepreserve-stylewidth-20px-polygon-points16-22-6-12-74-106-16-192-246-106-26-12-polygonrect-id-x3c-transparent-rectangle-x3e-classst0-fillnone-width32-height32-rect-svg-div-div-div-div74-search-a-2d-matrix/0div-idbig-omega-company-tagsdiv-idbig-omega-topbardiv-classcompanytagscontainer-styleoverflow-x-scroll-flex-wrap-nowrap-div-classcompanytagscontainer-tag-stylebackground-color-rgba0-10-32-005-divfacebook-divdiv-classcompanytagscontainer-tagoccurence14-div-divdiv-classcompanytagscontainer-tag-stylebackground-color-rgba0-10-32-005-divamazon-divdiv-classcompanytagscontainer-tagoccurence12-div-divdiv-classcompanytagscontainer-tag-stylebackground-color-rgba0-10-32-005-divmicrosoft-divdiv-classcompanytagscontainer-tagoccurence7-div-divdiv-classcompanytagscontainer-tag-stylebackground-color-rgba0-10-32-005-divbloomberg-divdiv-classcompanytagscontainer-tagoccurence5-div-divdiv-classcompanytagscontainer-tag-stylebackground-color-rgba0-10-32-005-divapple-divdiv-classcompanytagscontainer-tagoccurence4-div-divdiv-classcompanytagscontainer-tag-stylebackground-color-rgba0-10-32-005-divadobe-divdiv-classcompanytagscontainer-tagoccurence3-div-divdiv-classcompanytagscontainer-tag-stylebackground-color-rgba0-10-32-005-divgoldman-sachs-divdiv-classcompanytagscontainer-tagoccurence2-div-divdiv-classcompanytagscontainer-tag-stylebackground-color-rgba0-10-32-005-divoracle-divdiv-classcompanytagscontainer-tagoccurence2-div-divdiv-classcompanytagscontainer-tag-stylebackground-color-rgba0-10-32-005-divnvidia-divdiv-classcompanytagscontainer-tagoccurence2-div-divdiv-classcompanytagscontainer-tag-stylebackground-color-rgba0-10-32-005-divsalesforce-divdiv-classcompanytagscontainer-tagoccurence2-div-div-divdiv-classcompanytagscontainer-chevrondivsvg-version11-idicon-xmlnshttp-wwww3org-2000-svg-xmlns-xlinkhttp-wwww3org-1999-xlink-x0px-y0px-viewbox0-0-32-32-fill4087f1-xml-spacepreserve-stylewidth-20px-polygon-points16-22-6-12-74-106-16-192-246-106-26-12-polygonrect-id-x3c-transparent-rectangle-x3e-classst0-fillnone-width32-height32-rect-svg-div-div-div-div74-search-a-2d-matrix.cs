public class Solution{
      public bool SearchMatrix(int[][] matrix, int target) {
            var rowLength = matrix.Length;
            var colLength = matrix[0].Length;
            var left = 0;
            var right = rowLength * colLength - 1;
            
            while(left <= right){
                var mid = (left + right) / 2;
                var midValue = matrix[mid/colLength][mid%colLength];
                if(midValue == target){
                    return true;
                }else if(midValue < target){
                    left = mid + 1; 
                }else{
                    right = mid - 1;
                }
            }
            
            return false;
      }
}
