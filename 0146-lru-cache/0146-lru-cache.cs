public class LRUCache
{
    private int _capacity;
    private Dictionary<int, LinkedListNode<CacheItem>> _map;
    private LinkedList<CacheItem> _list;
    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _map = new();
        _list = new();
    }
    
    public int Get(int key)
    {
        if (_map.TryGetValue(key, out var node))
        {
            _list.Remove(node);
            _list.AddFirst(node);
            return node.Value.Value;
        }
        
        return - 1;
    }
    
    public void Put(int key, int value)
    {
        if (_map.TryGetValue(key, out var node))
        {
            node.Value.Value = value;
            _list.Remove(node);
            _list.AddFirst(node);
        }
        else
        {
            if (_map.Count >= _capacity)
            {
                var last = _list.Last;
                _list.RemoveLast();
                _map.Remove(last.Value.Key);
            }
            var newNode = new LinkedListNode<CacheItem>(new (key, value));
            _map.Add(key, newNode);
            _list.AddFirst(newNode);
        }
    }
}

public class CacheItem
{
    public int Key { get; set; }
    public int Value { get; set; }

    public CacheItem(int key, int value)
    {
        Key = key;
        Value = value;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */