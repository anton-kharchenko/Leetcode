public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        long nextTime = 0;
        long waitingTime = 0;

        for(var i = 0; i<customers.Length; i++){
            var arrival = customers[i][0];
            var currentTime = customers[i][1];
            nextTime = Math.Max(arrival, nextTime) + currentTime;
            waitingTime += nextTime - arrival;
        }
       
        return (double)waitingTime/customers.Length;
    }
}