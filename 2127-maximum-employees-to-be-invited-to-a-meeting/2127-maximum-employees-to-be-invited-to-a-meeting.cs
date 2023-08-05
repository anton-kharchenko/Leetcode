public class Solution {
    int[] _inDegrees = null;
    int _len = 0;
    
    public int MaximumInvitations(int[] favorite) {
        // Note: 1. Topology Sort to find level for each node which is not in circle
        //       2. Processing two typed cycles
        _len = favorite.Length;
        
        // top sort
        var level = new int[_len];
        var visited = new bool[_len];
        TopSort(favorite, level, visited);
        
        // handle cycle - the node in cycle is not visited yet
        var maxCycle = 0;
        var maxLinear = 0;
        
        for (int i = 0; i < _len; i++)
            if (!visited[i])
                if (favorite[favorite[i]] == i)
                    maxLinear += level[i] + 1;
                else
                    maxCycle = Math.Max(maxCycle, CountCycle(favorite, i, visited));
        
        return Math.Max(maxCycle, maxLinear);
    }
    
    void TopSort(int[] favorite, int[] level, bool[] visited)
    {
        // calc inDegrees
        _inDegrees = new int[_len];
        for (int i = 0; i < _len; i++)
            _inDegrees[favorite[i]]++;
        
        // init queue
        var q = new Queue<int>();
        for (int i = 0; i < _len; i++)
            if (_inDegrees[i] == 0)
                q.Enqueue(i);
        
        // topology sort
        var lvl = 0; 
        while (q.Count > 0)
        {
            int count = q.Count;
            lvl++;
            
            while (count > 0)
            {
                var cur = q.Dequeue();
                
                visited[cur] = true;
                
                var next = favorite[cur];
                _inDegrees[next]--;
                level[next] = lvl;
                
                if (_inDegrees[next] == 0)
                    q.Enqueue(next);
                
                count--;
            }
        }
    }
    
    int CountCycle(int[] favorite, int start, bool[] visited)
    {
        var count = 0;
        var cur = start;
        
        while (true)
        {
            if (visited[cur])
                break;

            visited[cur] = true;
            cur = favorite[cur];
            count++;
        }
        
        return count;
    }
}