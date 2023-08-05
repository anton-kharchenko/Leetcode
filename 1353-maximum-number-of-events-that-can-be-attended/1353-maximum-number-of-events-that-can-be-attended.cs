public class Solution {
    public int MaxEvents(int[][] events) {
      events = events.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();
        
        var calendar = new HashSet<int>();
        var lastEventEnd = events[events.Length -1][1];
        var prevStart = -1;
        var lastSlotBooked = -1;
        
        foreach (var day in events) {
            var start = day[0];
            var end = day[1];
            var calendarStart = start;
            
            // If the prev and current start at the same time, advance start by the last booked time
            if (prevStart == calendarStart) {
                calendarStart = lastSlotBooked + 1;
            } 
            for (var iter = calendarStart; iter <= end && iter <= lastEventEnd; ++iter) {
                if (!calendar.Contains(iter)) {
                    calendar.Add(iter);
                    lastSlotBooked = iter;
                    break;
                }
            }
            prevStart = start;            
        }
        
        return calendar.Count;
    }
}