public class Solution {
    public bool CanConstruct(string s, int k) {
        // if k number less than count of even group I cannot get all charactes  
        return k <= s.Length && k >= s
            .GroupBy(c=>c) // Group by char 
            .Select(g=>g.Count()) // Count how many members in each group 
            .Count(i=>i%2==1); // Count How many even group 
    }
}