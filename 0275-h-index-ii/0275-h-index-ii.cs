public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        var hIndex = 1;
        for(var i =citations.Length - 1; i>=0; i--){
            if(citations[i] <hIndex){
                return hIndex - 1;
            }
            hIndex++;
        }
        return citations.Length;
    }
}