public class Solution
{
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        var allByPosition = new List<EdgeInfo>();
        foreach (var building in buildings)
        {
            if (building[0] >= building[1]) continue;
            allByPosition.Add(new EdgeInfo() { Position = building[0], Height = building[2], IsStart = true });
            allByPosition.Add(new EdgeInfo() { Position = building[1], Height = building[2], IsStart = false });
        }

        var sortedPosition = allByPosition.OrderBy(x => x.Position).ToList();

        var res = new List<IList<int>>();
        var lastHeight = -1;
        var lastPosition = -1;
        var openByHeight = new SortedList<int, int>();

        foreach (var edgInf in sortedPosition)
        {
            if (edgInf.Position != lastPosition)
            {
                if (lastPosition != -1)
                {
                    var height = openByHeight.Count > 0 ? openByHeight.Keys[openByHeight.Count - 1] : 0;
                    if (lastHeight != height)
                    {
                        res.Add(new List<int> { lastPosition, height });
                    }

                    lastHeight = height;
                }

                lastPosition = edgInf.Position;
            }

            if (edgInf.IsStart)
            {
                if (!openByHeight.TryGetValue(edgInf.Height, out var countHeight))
                {
                    countHeight = 0;
                }

                openByHeight[edgInf.Height] = ++countHeight;
            }
            else
            {
                int countHeight = openByHeight[edgInf.Height];
                if (--countHeight == 0)
                    openByHeight.Remove(edgInf.Height);
                else
                    openByHeight[edgInf.Height] = countHeight;
            }
        }

        if (lastPosition != -1)
            res.Add(new List<int>() { lastPosition, 0 });

        return res;
    }
}

public class EdgeInfo
{
    public int Position;
    public int Height;
    public bool IsStart;
}