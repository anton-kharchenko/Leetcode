public class Solution {
    public long PutMarbles(int[] weights, int k) {
        int n = weights.Length - 1;
        
        int[] neighbourSum = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            neighbourSum[i] = weights[i] + weights[i + 1]; // 4, 8, 6 
        }
        
        Array.Sort(neighbourSum); // 4, 6, 8

        long result = 0;
        
        for (int i = 0; i < k - 1; i++)
        {
            result += neighbourSum[n - 1 - i] - neighbourSum[i]; // neighbourSum[3-1-0] - neighbourSum[0]
        }
        
        return result;
    }
}