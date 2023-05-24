public class Solution {
    public bool DivideArray(int[] nums) {
        return nums.GroupBy(x => x).Select(x => x.Count()).All(x => x % 2 == 0);
    }
}