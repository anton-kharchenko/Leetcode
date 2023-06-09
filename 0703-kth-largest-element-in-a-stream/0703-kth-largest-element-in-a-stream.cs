public class KthLargest {
    List<int> list = null;
    int index = 0;
    public KthLargest(int k, int[] nums) {
        index = k;
        list = nums.ToList();
    }
    
    public int Add(int val) {
        list.Add(val);
        list.Sort();
        return list[list.Count - index];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */