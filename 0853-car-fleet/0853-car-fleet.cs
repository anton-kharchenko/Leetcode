public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
     var stack = new Stack<double>();
     var pairs = position.Select((t, i) => (t, (double)speed[i])).ToList();

     pairs.Sort();
     pairs.Reverse();
        
     foreach(var (pos, sp) in pairs){
         stack.Push((target - pos) / sp);
         if (stack.Count < 2) continue;
         var last = stack.Pop();
         var previous = stack.Peek();
         if(last>previous){
             stack.Push(last); 
         }
     }
        
     return stack.Count;
    }
}