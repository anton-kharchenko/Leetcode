public class Solution {
    public int MincostTickets(int[] days, int[] costs)
    {
        var daysCount = days.Max() + 1;
        var lookup = new int[daysCount];

        for (int i = 0; i < lookup.Length; i++)
        {
            if (!days.Contains(i))
            {
                lookup[i] = i - 1 >= 0 ? lookup[i - 1] : 0;
            }
            else
            {
                var dayCost = costs[0] + (i - 1 >= 0 ? lookup[i - 1] : 0);
                var weekCost = costs[1] + (i - 7 >= 0 ? lookup[i - 7] : 0);
                var monthCost = costs[2] + (i - 30 >= 0 ? lookup[i - 30] : 0);
                lookup[i] = Math.Min(Math.Min(dayCost, weekCost), monthCost);
            }
        }

        return lookup[daysCount - 1];
        //return Recursion(days, costs, 0, daysCount, new int[daysCount]);
    }

    
}