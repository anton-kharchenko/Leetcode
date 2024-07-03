public class Solution {
    public int MinDifference(int[] nums) {
        if(nums.Length <= 4) return 0;

        var min_heap = new PriorityQueue<int, int>();
        var max_heap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y)=>y.CompareTo(x)));
        foreach(var num in nums){
            max_heap.Enqueue(num, num);
            min_heap.Enqueue(num, num);
            if(min_heap.Count > 4){
                max_heap.Dequeue();
                min_heap.Dequeue();
            }
        }

        var max_array = new int[4];
        var min_array = new int[4];
        var index = 0;
        while(min_heap.Count>0){
            max_array[index] = max_heap.Dequeue();
            min_array[index] = min_heap.Dequeue();
            index += 1;
        }

        Array.Sort(max_array);
        Array.Sort(min_array);
        var result = int.MaxValue;
        for(var i = 0; i<4; i++){
            result = Math.Min(result, Math.Abs( max_array[i] - min_array[i]));
        }

        return result;
    }
}