public class LRUCache {

    private readonly int _capacity;
    private readonly Dictionary<int, LinkedListNode<CacheItem>> _cacheMap;
    private readonly LinkedList<CacheItem> _cacheList;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
        _cacheList = new LinkedList<CacheItem>();
    }
    
    public int Get(int key) {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            _cacheList.Remove(node);
            _cacheList.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            node.Value.Value = value;
            _cacheList.Remove(node);
            _cacheList.AddFirst(node);
        }
        else
        {
            if (_cacheMap.Count >= _capacity)
            {
                var lastNode = _cacheList.Last;
                _cacheMap.Remove(lastNode.Value.Key);
                _cacheList.RemoveLast();
            }

            var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            _cacheMap.Add(key, newNode);
            _cacheList.AddFirst(newNode);
        }
    }

    private class CacheItem
    {
        public int Key { get; }
        public int Value { get; set; }

        public CacheItem(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}