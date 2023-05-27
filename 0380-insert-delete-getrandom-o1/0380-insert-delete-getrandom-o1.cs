public class RandomizedSet {
    HashSet<int> set = null;
    int count = 0;
    Random rnd = new Random();
    public RandomizedSet() {
        set = new HashSet<int>();
    }
    
    public bool Insert(int val) {
        if(!set.Contains(val)){
            set.Add(val);
            count++;
            return true;
        }
        
        return false;
    }
    
    public bool Remove(int val) {
        if(set.Contains(val)){
            set.Remove(val);
            count--;
            return true;
        }
        
        return false;
    }
    
    public int GetRandom() {
        var index = rnd.Next(0, count);
        return set.ElementAt(index);
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */