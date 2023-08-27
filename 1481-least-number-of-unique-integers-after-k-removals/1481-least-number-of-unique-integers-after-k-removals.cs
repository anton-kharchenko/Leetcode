public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        var dictionary = new Dictionary<int, int>();
        
        foreach(var item in arr){
            if(dictionary.ContainsKey(item)){
                dictionary[item]++;
            }else{
                dictionary.Add(item, 1);
            }
        }

        var list = dictionary.Values.ToList();
        list.Sort();
        int count = 0;

        for (var i = 0; i<list.Count; i++)
        {
            var current = list[i];

            if (k >= current)
            {
                k -= current;
            }
            else
            {
                count = list.Count - i;
                break;
            }
        }
        
        return count;
    }
}