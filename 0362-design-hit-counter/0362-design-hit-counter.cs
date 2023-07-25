public class HitCounter {
    Dictionary<int, int> dict;
    public HitCounter() {
        dict = new Dictionary<int, int>();
    }
    
    public void Hit(int timestamp) {
        if(dict.ContainsKey(timestamp)){
            dict[timestamp]++;
        }else{
            dict.Add(timestamp, 1);
        }
    }
    
    public int GetHits(int timestamp) {
       var timeBound = Math.Max(1, timestamp - 300 + 1);
        
       return dict.Where(x=>x.Key <= timestamp && x.Key >= timeBound).ToList().Sum(x=>x.Value);
    }
}

/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.Hit(timestamp);
 * int param_2 = obj.GetHits(timestamp);
 */