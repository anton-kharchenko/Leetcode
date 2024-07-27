public class LFUCache {

    private Dictionary<int, CacheItem<int, CacheItem<int, int>>> _cache;
    private Dictionary<int, List<CacheItem<int, int>>> _frequencies;
    private int _minFrequency;
    private int _capacity;

    public LFUCache(int capacity) {
        _cache = new();
        _frequencies = new();
        _minFrequency = 0;
        _capacity = capacity;        
    }    
    
    public void Insert(int key, int frequency, int value) {
        if (!_frequencies.ContainsKey(frequency)) {
            _frequencies[frequency] = new List<CacheItem<int, int>>();
        }
        _frequencies[frequency].Add(new CacheItem<int, int>(key, value));
        _cache[key] = new CacheItem<int, CacheItem<int, int>>(frequency, _frequencies[frequency].Last());
    }
    
    public int Get(int key) {
        if (!_cache.TryGetValue(key, out var cacheItem)) {
            return -1;
        }
        
        var frequency = cacheItem.Key;
        var cacheItemValue = cacheItem.Value;
        
        _frequencies[frequency].Remove(cacheItemValue);

        if (_frequencies[frequency].Count == 0 && _minFrequency == frequency)
            _minFrequency += 1;
        
        var nextFrequency = frequency + 1;
        
        Insert(key, nextFrequency, cacheItemValue.Value);
        return cacheItemValue.Value;            
    }
    
    public void Put(int key, int value) {
        if (_cache.TryGetValue(key, out var cacheItem)) {
            cacheItem.Value.Value = value;
            Get(key);
            return;
        }        
        if (_capacity == _cache.Count) {
            _cache.Remove(_frequencies[_minFrequency].First().Key);
            _frequencies[_minFrequency].RemoveAt(0);
        }
        _minFrequency = 1;
        Insert(key, 1, value);               
    }

    private class CacheItem<TKey, TValue> {
        public TKey Key;
        public TValue Value;

        public CacheItem(TKey key, TValue value) {
            Key = key;
            Value = value;
        }
    }
}
