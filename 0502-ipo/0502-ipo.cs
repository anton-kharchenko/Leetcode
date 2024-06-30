public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        var length = profits.Length;
        var items = new List<(int, int)>();
        for(var i = 0; i<profits.Length; i++){
            items.Add((capital[i], profits[i]));
        }

        var orderedItems = items.OrderBy(i=>i.Item1).ToList();
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x,y)=>y.CompareTo(x)));
        int index = 0;
        while (k>0)
        {
            while (index<length && orderedItems[index].Item1 <= w)
            {
                pq.Enqueue(orderedItems[index].Item2, orderedItems[index].Item2);
                index += 1;
            }

            if (pq.Count == 0)
            {
                break;
            }

            k -= 1;
            w += pq.Dequeue();
        }

        return w;
    }
}