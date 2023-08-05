public class Solution
{
    public int StoneGameII(int[] piles)
    {
        var dp = new int[piles.Length, piles.Length];

        for (int i = piles.Length - 2; i >= 0; i--)
            piles[i] += piles[i + 1]; // Prefix sum : [2,7,9,4,4]  => [26,24,17,8,4]

        return StoneGameIiUntil(piles, dp, 0, 1);
    }

    private int StoneGameIiUntil(int[] pilesSuffixSum, int[,] dp, int idx, int m)
    {
        int maxStones = 0, movesPossible = Math.Min(pilesSuffixSum.Length, 2 * m + idx); // Min possible move for player

        if (movesPossible >= pilesSuffixSum.Length)
            return pilesSuffixSum[idx];

        if (dp[idx, m] != 0)
            return dp[idx, m];

        for (int i = idx; i < movesPossible; i++)
        {
            var current = pilesSuffixSum[idx] - StoneGameIiUntil(pilesSuffixSum, dp, i + 1, Math.Max(i - idx + 1, m));
            
            maxStones = Math.Max(maxStones, current);
        }

        dp[idx, m] = maxStones;
        
        return dp[idx, m];
    }
}