/**
 * // This is BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *     public int Get(int row, int col) {}
 *     public IList<int> Dimensions() {}
 * }
 */

class Solution {
    public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix) {
        var data = binaryMatrix.Dimensions();
        var row = data[0] - 1;
        var col = data[1] - 1;
        
        var res = -1;
        
        while(row>= 0 && col >= 0){
            if(binaryMatrix.Get(row, col) == 1){
                res = col;
                col -= 1;
            }else{
                row -= 1;
            }
        }
        
        return res;
    }
}

