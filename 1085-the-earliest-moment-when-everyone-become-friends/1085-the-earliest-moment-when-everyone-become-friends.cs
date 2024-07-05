public class Solution {
    public int EarliestAcq(int[][] logs, int n) {
        int[] parents = new int[n];
        int[] ranks = new int[n];
        int result = 1;

        for(var i = 0; i<n; i++){
            parents[i] = i;
            ranks[i] = 0;
        }

        Array.Sort(logs, (x,y)=>x[0].CompareTo(y[0]));

        int Find(int value){
            if(value == parents[value]){
                return parents[value];
            }
            int parent = Find(parents[value]);
            parents[value] = parent;
            return parent;
        }

        int Union(int friend1, int friend2){
            var paretn1 = Find(friend1);
            var paretn2 = Find(friend2);

            if(paretn1 == paretn2){
                return 0;
            }

            if(ranks[paretn1] > ranks[paretn2]){
                parents[paretn2] = paretn1;
            }else if(ranks[paretn1] < ranks[paretn2]){
                parents[paretn1] = paretn2;
            }else{
                parents[paretn2] = paretn1;
                ranks[paretn1] += 1;
            }

            return 1;
        }

                
        foreach(var log in logs){
            result += Union(log[1], log[2]);
            if(result == n){
                return log[0];
            }
        } 

        return -1;
    }
}