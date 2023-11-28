public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> result = new List<int>();
        
        for(int i = 0; i<nums.Length; i += 2){
            FillList(nums[i], nums[i+1], result);
        }
        
        return result.ToArray();
    }
    
    public void FillList(int freq, int val, List<int> list){
        for(int i = 0; i<freq; i++){
            list.Add(val);
        }
    }
}