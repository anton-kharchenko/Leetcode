public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var length = cost.Length;
        for(var i = 2; i< length; i++)
            cost[i] = Math.Min(cost[i-1], cost[i-2]) + cost[i];
        return Math.Min(cost[length - 1], cost[length - 2]);
    }
}