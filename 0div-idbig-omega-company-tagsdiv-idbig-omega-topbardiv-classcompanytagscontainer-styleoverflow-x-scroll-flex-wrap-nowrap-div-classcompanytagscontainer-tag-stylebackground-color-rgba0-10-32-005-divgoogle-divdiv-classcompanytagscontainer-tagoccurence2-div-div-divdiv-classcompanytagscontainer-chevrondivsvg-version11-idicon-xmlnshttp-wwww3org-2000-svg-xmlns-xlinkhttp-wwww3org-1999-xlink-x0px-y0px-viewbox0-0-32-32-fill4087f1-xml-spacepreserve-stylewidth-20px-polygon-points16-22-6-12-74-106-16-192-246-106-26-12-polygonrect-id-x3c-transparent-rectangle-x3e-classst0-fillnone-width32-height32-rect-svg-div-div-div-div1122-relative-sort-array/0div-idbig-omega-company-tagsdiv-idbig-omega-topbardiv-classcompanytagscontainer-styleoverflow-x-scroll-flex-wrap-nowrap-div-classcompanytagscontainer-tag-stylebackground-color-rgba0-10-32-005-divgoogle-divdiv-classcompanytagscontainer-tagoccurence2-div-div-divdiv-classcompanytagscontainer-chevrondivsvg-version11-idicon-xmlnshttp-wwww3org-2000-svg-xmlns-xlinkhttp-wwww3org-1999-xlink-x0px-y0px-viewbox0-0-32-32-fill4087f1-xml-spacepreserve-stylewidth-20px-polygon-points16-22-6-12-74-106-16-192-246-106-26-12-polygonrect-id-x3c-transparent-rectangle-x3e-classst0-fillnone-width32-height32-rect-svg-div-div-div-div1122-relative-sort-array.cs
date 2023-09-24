public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var res = new List<int>();
        var dict = new Dictionary<int, int>();
        
        foreach(var i in arr1){
            dict.TryAdd(i, 1);
            dict[i]++;
        }
        
        foreach(var i in arr2){
            
            var val = dict[i];
            
            while(val > 1){
                res.Add(i);
                val--;
            }
        }
  var sorted = arr1
            .Where(num => !arr2.Contains(num))
            .ToArray();
        Array.Sort(sorted);
        
        foreach(var i in sorted){
            res.Add(i);
        }
        
        return res.ToArray();
    }
}