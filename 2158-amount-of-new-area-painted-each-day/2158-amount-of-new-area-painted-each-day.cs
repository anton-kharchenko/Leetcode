public class Solution
{
    public int[] AmountPainted(int[][] paint)
    {
       
    var m = int.MaxValue;
        var n = 0;
        foreach (var p in paint)
        {
            n = Math.Max(n, p[1] + 1);
            m = Math.Min(m, p[0]);
        }

        var painted = new int[n];
        for (int i = m; i < n; i++)
        {
            painted[i] = -1;
        }

        var answer = new int[paint.Length];
        for (int i = 0; i < paint.Length; i++)
        {
            int start = paint[i][0];
            int end = paint[i][1] - 1;   // inclusive blocks
            int count = 0;
            for (int j = start; j <= end; j++)
            {
                if (painted[j] == -1)
                {
                    count++;
                }
                else
                {
                    j = painted[j];
                }

                painted[j] = painted[j] > end ? painted[j] : end; // we will paint till this anyhow
            }
            answer[i] = count;
        }
        return answer;
    }
}