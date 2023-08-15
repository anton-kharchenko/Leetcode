public class RandomizedCollection {
    Dictionary<int, int> res;
    List<int> values;
    public RandomizedCollection() {
        res = new Dictionary<int, int>();
        values = new List<int>();
    }
    
    public bool Insert(int val) {
        if(res.ContainsKey(val)){
            res[val]++;
            values.Add(val);
            return false;
        } 
        
        values.Add(val);
        res.Add(val, 1);
        return true;
    }
    
    public bool Remove(int val) {
         if(res.ContainsKey(val)){
             if(res[val]==1){
                res.Remove(val);
                 values.Remove(val);
                return true;
             }else{
                res[val]--;
                values.Remove(val);
                return true;
             }
        }
        return false;
    }
    
    public int GetRandom() {
       return values[new Random().Next(values.Count)];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */