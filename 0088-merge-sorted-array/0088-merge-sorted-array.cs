public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var pq = new PriorityQueue<int, int>();
        var index = 0;
        while(m  > 0 && index < nums1.Length){
            pq.Enqueue(nums1[index], nums1[index]);    
            m -= 1;    
            index += 1;
        }

        index = 0;
        while(n  > 0 && index < nums2.Length){
            pq.Enqueue(nums2[index], nums2[index]);    
            n -= 1;    
            index += 1;
        }

        index = 0;
        while(pq.Count > 0 && index < nums1.Length){
           nums1[index] = pq.Dequeue();
           index += 1;
        }
    }
}