public class Solution
{
    public int StoneGameII(int[] piles)
    {
        var dp = new int[piles.Length, piles.Length];

        for (int i = piles.Length - 2; i >= 0; i--)
            piles[i] += piles[i + 1];

        return StoneGameIIUntil(piles, dp, 0, 1);
    }

    private int StoneGameIIUntil(int[] pilesSuffixSum, int[,] dp, int idx, int M)
    {
        int max_stones = 0, moves_possible = Math.Min(pilesSuffixSum.Length, 2 * M + idx);

        if (moves_possible >= pilesSuffixSum.Length)
            return pilesSuffixSum[idx];

        if (dp[idx, M] != 0)
            return dp[idx, M];

        for (int i = idx; i < moves_possible; i++)
        {
            max_stones = Math.Max(max_stones, pilesSuffixSum[idx] - StoneGameIIUntil(pilesSuffixSum, dp, i + 1, Math.Max(i - idx + 1, M)));
        }

        dp[idx, M] = max_stones;
        return dp[idx, M];
    }
}