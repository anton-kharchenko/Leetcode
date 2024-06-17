public class Solution {
    public bool JudgeSquareSum(int c) {
        for (long a = 0; a * a <= c; a++) {
            long b = c -  a * a;
            if (BinarySearch(0, b, b))
                return true;
        }
        return false;
    }

    public bool BinarySearch(long start, long end, long c)
    {
        while(start <= end){
            var mid = (end + start) / 2;
            var total = mid * mid;
            if(total == c){
                return true;
            }
            if(total > c){
                end = mid - 1;
            }else{
                start = mid + 1;
            }
        }

        return false;
    }
}