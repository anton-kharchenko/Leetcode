public class TimeMap {
    Dictionary<string, List<(string value1, int timestamp)>> map;
    public TimeMap() {
        map  = new Dictionary<string, List<(string, int)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        var val = new List<(string, int)>();
        if(!map.ContainsKey(key)){
            map.Add(key,  val);
        }
        map[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        var res = "";
        if(!map.ContainsKey(key)){
            return res;
        }
        
        var value = map[key];
        var left = 0;
        var right = value.Count;
        
        while(left<right){
            
            var mid = (left + right) / 2;
            
            if(value[mid].timestamp == timestamp){
                res = value[mid].value1;
                return res;
            }
            else if(value[mid].timestamp < timestamp){
                res = value[mid].value1;
                left = mid +1;
            }
            else{
                right = mid;
            }
        }
        
        
        return res;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */