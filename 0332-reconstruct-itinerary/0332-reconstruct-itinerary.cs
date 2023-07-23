public class Solution {
    List<string> res = new List<string>();
    Dictionary<string, List<string>> flights = new Dictionary<string, List<string>>();
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        
        foreach (var ticket in tickets) {
            flights.TryAdd(ticket[0], new List<string>());
            flights[ticket[0]].Add(ticket[1]);
        }
        
        foreach(var flight in flights ){
            flight.Value.Sort();
        }
        
       Dfs("JFK"); 

        return res;
    }
    
    private void Dfs(string departure){
        
        while(flights.ContainsKey(departure) && flights[departure].Count>0){
            var next = flights[departure][0];
            flights[departure].RemoveAt(0);
            Dfs(next);
        }
        
        res.Insert(0, departure);
    }
}