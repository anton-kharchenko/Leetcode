public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        var pq = new PriorityQueue<int, int>();
        foreach(var number in nums){
            pq.Enqueue(number, number);
            if(pq.Count > k){
                pq.Dequeue();
            }
        }

        return pq.Peek();
    }
}