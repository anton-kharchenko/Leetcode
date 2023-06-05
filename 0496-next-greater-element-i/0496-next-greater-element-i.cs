public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var ans= new int[nums1.Length];
        Array.Fill(ans, -1);
        
        for(var i = 0; i<nums1.Length; i++){
            for(var j = 0; j<nums2.Length; j++){
            if (nums1[i] != nums2[j]) continue;
            for(var k= j+1; k<nums2.Length; k++)
            {
                if (nums2[k] <= nums2[j]) continue;
                ans[i] = nums2[k];
                break;
            }
            }
        }
        
        return ans;
    }
}