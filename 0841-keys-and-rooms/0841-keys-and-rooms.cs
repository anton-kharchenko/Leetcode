public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var visited = new HashSet<int>();
        var q = new Queue<int>();
        q.Enqueue(0);
        visited.Add(0);
        
        
        while(q.Count>0){
            var currentRoom = q.Dequeue();
            foreach(var room in rooms[currentRoom]){
                if(visited.Contains(room)) continue;
                q.Enqueue(room);
                visited.Add(room);
            }
            
        }
        
        
        return rooms.Count == visited.Count;
    }
}