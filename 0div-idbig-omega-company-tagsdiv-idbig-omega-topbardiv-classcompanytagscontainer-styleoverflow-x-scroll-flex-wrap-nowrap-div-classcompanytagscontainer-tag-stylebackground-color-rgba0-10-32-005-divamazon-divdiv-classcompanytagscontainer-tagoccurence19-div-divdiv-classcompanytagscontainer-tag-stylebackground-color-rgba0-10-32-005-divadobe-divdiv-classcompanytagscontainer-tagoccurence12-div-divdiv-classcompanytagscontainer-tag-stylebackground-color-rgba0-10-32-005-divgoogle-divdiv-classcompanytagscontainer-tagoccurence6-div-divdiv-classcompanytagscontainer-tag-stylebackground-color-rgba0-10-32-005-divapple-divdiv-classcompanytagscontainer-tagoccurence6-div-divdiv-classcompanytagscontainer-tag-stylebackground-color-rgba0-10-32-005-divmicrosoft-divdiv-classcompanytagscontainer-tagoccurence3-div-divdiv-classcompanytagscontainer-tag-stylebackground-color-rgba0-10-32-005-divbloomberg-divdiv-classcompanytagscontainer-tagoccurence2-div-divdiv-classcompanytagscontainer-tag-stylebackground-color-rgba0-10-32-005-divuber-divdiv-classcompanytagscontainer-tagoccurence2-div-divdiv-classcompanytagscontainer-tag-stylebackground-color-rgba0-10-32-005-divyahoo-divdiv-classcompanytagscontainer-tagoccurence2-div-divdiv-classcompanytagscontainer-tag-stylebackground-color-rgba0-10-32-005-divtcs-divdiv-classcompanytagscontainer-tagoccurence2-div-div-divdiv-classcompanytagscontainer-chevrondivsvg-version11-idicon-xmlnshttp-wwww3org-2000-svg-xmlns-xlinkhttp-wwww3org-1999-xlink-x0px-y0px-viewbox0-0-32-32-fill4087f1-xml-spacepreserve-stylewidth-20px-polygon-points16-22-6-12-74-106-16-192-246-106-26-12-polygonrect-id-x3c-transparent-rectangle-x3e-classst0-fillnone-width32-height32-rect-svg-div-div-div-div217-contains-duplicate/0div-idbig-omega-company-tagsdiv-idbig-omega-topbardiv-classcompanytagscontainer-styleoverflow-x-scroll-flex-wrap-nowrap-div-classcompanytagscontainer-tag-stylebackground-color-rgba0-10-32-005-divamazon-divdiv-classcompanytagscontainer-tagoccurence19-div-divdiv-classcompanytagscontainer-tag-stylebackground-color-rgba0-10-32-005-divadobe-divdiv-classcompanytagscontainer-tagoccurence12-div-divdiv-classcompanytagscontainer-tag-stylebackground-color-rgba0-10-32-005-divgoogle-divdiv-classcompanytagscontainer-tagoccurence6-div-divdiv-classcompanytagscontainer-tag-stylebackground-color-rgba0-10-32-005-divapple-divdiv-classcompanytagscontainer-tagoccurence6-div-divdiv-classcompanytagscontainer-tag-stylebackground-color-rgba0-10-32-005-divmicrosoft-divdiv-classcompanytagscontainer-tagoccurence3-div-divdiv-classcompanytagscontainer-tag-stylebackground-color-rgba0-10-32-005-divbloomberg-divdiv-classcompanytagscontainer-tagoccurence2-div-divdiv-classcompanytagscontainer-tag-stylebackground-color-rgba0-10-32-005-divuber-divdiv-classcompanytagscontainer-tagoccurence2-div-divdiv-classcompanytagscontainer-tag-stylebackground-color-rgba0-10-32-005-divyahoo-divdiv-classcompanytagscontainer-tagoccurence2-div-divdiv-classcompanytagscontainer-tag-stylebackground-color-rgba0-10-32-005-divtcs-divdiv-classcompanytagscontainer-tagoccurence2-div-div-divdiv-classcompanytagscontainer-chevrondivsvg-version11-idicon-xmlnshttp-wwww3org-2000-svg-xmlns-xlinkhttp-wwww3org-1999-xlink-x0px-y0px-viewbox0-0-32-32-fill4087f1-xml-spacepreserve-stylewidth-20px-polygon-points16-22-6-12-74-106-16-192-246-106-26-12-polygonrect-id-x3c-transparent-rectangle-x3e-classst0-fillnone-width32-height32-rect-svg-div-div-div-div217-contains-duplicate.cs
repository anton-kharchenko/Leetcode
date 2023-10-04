public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hs = new HashSet<int>();
        foreach(var n in nums){
          if(hs.Contains(n)){
            return true;
        }else{
            hs.Add(n);
        }
        }

        
        return false;
    }
}
