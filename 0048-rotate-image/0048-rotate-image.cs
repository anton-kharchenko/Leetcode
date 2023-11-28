public class Solution {
    public void Rotate(int[][] matrix) {
        int length = matrix.Length;
        for(int level = 0; level<length/2; level++){
            int first = level;
            int last = length - 1 - level;
            for(int i = first; i<last; i++){
                int offset = i - first;
                int topLeftElement = matrix[first][i];
                matrix[first][i] =  matrix[last - offset][first]; // topLeft
                matrix[last - offset][first] = matrix[last][last - offset];  // bottomLeft
                matrix[last][last - offset] = matrix[i][last]; //bottomRight
                matrix[i][last] = topLeftElement; // topRight            
            }
        }
    }
}