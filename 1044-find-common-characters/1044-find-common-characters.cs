public class Solution {
    public IList<string> CommonChars(string[] words) {
        var dictionary = GetDict(words[0]);
        var res = new List<string>();


        for(var i = 1; i<words.Length; i++){
            var word = words[i];
            var newDict = GetDict(word);
            foreach(var (key, value) in newDict){
                if(dictionary.ContainsKey(key)){
                    dictionary[key] = Math.Min(dictionary[key], value);
                }else{
                    newDict.Remove(key);
                }
            }

            foreach(var (key, value) in dictionary){
                if(newDict.ContainsKey(key)){
                    continue;
                }else{
                    dictionary.Remove(key);
                }
            }
        }

        foreach(var (key, value) in dictionary)
        {
            var index = value;
            while(index > 0){
                res.Add(key.ToString());
                index -= 1;
            }
        }


        return res;
    }
    
    public Dictionary<char, int> GetDict(string word){
        var dict = new Dictionary<char, int>();
        foreach(var i in word){
            dict.TryAdd(i, 0);
            dict[i] += 1;
        }
        return  dict;
    }
}

