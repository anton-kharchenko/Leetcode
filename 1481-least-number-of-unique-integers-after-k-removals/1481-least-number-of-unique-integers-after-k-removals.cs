public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
            var dict = new Dictionary<int, int>();
            foreach(var i in arr){
                if(dict.ContainsKey(i)){
                    dict[i]++;
                }else{
                    dict.Add(i, 1);
                }
            }
        
            var list = dict.Values.ToList();
            list.Sort();
        
            int count = 0;
            
            for(var i = 0; i<list.Count; i++){
                var curr = list[i];
                
                if(k>=curr){
                    k -= curr;
                }else{
                    count = list.Count  - i;
                    break;
                }
                
            }
        
        
            return count;
        
    }
}