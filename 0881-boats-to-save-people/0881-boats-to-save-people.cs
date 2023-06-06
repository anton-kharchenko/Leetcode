public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        var l = 0;
        var r = people.Length - 1;
        var res = 0;
        Array.Sort(people);
        
        while(l<=r){
            var remain = limit - people[r]; 
            r--;
            res++;
            if(l<=r && people[l]<=remain){
                l++;
            }
        }
        
        return res;
    }
}