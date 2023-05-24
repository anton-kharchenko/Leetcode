public class Solution {
    public int AddDigits(int num) {
    var list = new List<int>();
        
    while(num >= 10){
        list.AddRange(num.ToString().Select(i => int.Parse(i.ToString())));
        num = list.Sum(); 
        list.Clear();
    }
        
    return num;

    }
}