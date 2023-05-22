public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var length = candies.Length;
        var result = new bool[length];
        var list = candies.ToList();
        
        for(var i = 0; i<length; i++  ){
            result[i] =  list.All(el=>el <= candies[i] + extraCandies);
        }
        
        return result;
    }
}