public class Solution {
    public string LargestNumber(int[] nums) {
      var selected = nums.Select(i=>i.ToString()).ToArray();
        
        Array.Sort(selected, (s1, s2)=> {
            var r1 = s1 + s2;
            var r2 = s2 + s1;
            
            return r2.CompareTo(r1);
        });
        
        if(selected[0] == "0") return "0";
        
        return string.Join("",selected);
    }
    

}