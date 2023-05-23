public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dic = new Dictionary<int, int>();
        
        for(var i=0; i<arr.Length; i++){
            if(dic.ContainsKey(arr[i])){
                dic[arr[i]] += 1;
            }else{
                dic.Add(arr[i], 1);
            }
        }
        
        var set= new HashSet<int>();
        
        foreach(var (key, value) in dic){
            if(set.Contains(value)){
                return false;
            }else{
                set.Add(value);
            }
        }
        
        return true;
    }
}