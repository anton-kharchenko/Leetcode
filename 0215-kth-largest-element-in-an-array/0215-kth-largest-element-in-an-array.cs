public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
       var pq = new PriorityQueue<int, int>();
        
        for(var index = 0; index< nums.Length;index++){
            pq.Enqueue(nums[index], nums[index]);
            if(pq.Count>k)
                pq.Dequeue();
        }
        
        return pq.Peek();
    }
}