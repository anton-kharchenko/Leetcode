public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        var dict = new Dictionary<int, HashSet<int>>();
        
        foreach(var reservedSeat in reservedSeats){
            var row = reservedSeat[0];
            var col = reservedSeat[1];
            dict.TryAdd(row, new HashSet<int>());
            dict[row].Add(col);    
        }
        var res = (n - dict.Count) * 2;
        
        foreach(var hs in dict.Values){
            var reservedMid = false;
            if(!IsReserved(2, 5, hs)){
                res++;
                reservedMid = true;
            }
            
            if(!IsReserved(6, 9, hs)){
                res++;
                reservedMid = true;
            }
            
            if(!IsReserved(4, 7, hs) && !reservedMid){
                res++;
            }
        }   
        
        return res;
    }
    
    public bool IsReserved(int low, int high, HashSet<int> hs){
        for(var i = low; i<= high; i++){
            if(hs.Contains(i)) 
                return true;
        }
        return false;
    }
    
    
}