public class Solution {
    
    const int Modulo = 1000000007;
    
    public int CountNicePairs(int[] nums) {

      var set = new Dictionary<int, int>();

      for (var i = 0; i < nums.Length; i++)
      {
        var key = nums[i] - Convert.ToInt32(string.Concat(nums[i].ToString().Reverse()));
        
        if(set.ContainsKey(key)){
            set[key] += 1;
        }else{
            set.Add(key, 1);
        }
             
       }

    long res = 0;
    foreach (var (key, value) in set)
    {
            long val = value;
            res += ((val)*(val-1))/2;
    }
        
    return (int)(res %= Modulo);
        
    }
}