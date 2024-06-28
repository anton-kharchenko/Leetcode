public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs){
        var hashMap = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            var sortedStr =  GetString(str);
            if(!hashMap.ContainsKey(sortedStr)){
                hashMap.Add(sortedStr, new List<string>());
            }
            hashMap[sortedStr].Add(str);
        }

        var result = new List<IList<string>>();
        foreach (var (_, value) in hashMap)
        {
            result.Add(value);
        }
        return result;
    }

    public string GetString(string originalString){
        var charArr = originalString.ToCharArray();
        Array.Sort(charArr);
        return new string(charArr);
    }
}