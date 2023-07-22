public class NumArray {
    List<int> sum= new List<int>();
    public NumArray(int[] nums) {
        var curr = 0;
        for(var i = 0; i<nums.Length; i++){
           curr += nums[i]; 
           sum.Add(curr);
        }

    }
    
    public int SumRange(int left, int right) {
        if(left==0)
            return sum[right];
        return sum[right] - sum[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */