public class Solution
{
    private int[] parents;
    private int[] ranks;
    public bool ValidTree(int n, int[][] edges)
    {
        parents = new int[n];
        ranks = new int[n];
        for (int i = 0; i < n; i++)
        {
            parents[i] = i;
            ranks[i] = 1;
        }

        foreach (var edge in edges)
        {
            if (!CanUnion(edge[0], edge[1]))
            {
                return false;
            }
        }

        var basic = Find(0);
        for (int i = 1; i < n; i++)
        {
            if (Find(i) != basic)
            {
                return false;
            }
        }

        return true;
    }

    private int Find(int child)
    {
        if (child != parents[child])
        {
            parents[child] = Find(parents[child]);
        }
        return parents[child];
    }

    private bool CanUnion(int fNumber, int sNumber)
    {
        var fParent = Find(fNumber);
        var sParent = Find(sNumber);
        if(fParent == sParent) return false;

        if (ranks[fParent] > ranks[sParent])
        {
            parents[sParent] = fParent;
        }else if (ranks[fParent] < ranks[sParent])
        {
            parents[fParent] = sParent;
        }
        else
        {
            parents[sParent] = fParent;
            ranks[fParent] += 1;
        }
        
        return true;
    }
}