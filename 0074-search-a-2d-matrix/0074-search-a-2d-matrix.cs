public class Solution{
      public bool SearchMatrix(int[][] matrix, int target) {
       var rowLength = matrix.Length;
       var colLength = matrix[0].Length;
          
       int left = 0;
       int right = rowLength * colLength -1;
          
          while(left <= right){
              var mid = (left + right) /2;
              var curr = matrix[mid/colLength][mid%colLength];
              if(curr>target){
                  right =  mid - 1;
              }else if(curr<target){
                  left = mid + 1;
              }else{
                  return true;
              }
              
          }
          
          return false;
}
}
