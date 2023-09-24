public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        var hs = new Dictionary<int, HashSet<int>>();
        foreach(var reservedSeat in reservedSeats){
            hs.TryAdd(reservedSeat[0], new HashSet<int>());
            hs[reservedSeat[0]].Add(reservedSeat[1]);
        }
        int res = (n - hs.Count) * 2;
        foreach(var col in hs.Values){
            var reservedMiddle = false; 
            if(!IsReserved(col, 2, 5)){
                reservedMiddle = true;
                res++;
            }
            
             if(!IsReserved(col, 6, 9)){
                reservedMiddle = true;
                res++;
            }
            
            
            if(!reservedMiddle && !IsReserved(col, 4, 7)){
                res++;
            }
        }
        
        return res;
    }
    
    public bool IsReserved(HashSet<int> col, int low, int high){
        for(var i = low; i<= high; i++){
            if(col.Contains(i)){
                return true;
            }
        }
        
        return false;
    }
}