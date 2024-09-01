public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (m * n != original.Length) return [];
        
        var result = new int[m][];
        for (int i = 0; i < m; i++)
        {
            result[i] = new int[n];
        }

        var mIndex = 0;
        var nIndex = 0;
        
        foreach (var value in original)
        {
            result[mIndex][nIndex] = value;
            nIndex += 1;
            if (nIndex != n) continue;
            nIndex = 0;
            mIndex += 1;
        }
        
        return result;
    }
}