public class LRUCache {
    Dictionary<int,int> dict=new Dictionary<int,int>();
    IList<int> list;
    int cap;
    
    public LRUCache(int capacity) {
        list=new List<int>();
        cap=capacity;
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key))
            return -1;
        int ret=dict[key];
        list.Remove(key);
        list.Add(key);
        return ret;
    }
    
    public void Put(int key, int value) {
      if(dict.ContainsKey(key))
        {
            dict[key]=value;
            list.Remove(key);
            list.Add(key);
            return;
        }
        if(dict.Count==cap)
        {
            int evit=list[0];
            dict.Remove(evit);
            list.Remove(evit);
        }
        dict.Add(key,value);
        list.Add(key);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */