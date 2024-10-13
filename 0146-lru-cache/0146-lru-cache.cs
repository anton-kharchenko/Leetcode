public class LRUCache
{
    private Dictionary<int, LinkedListNode<CacheItem>> _frequency = new();
    private LinkedList<CacheItem> _linkedList =new();
    private int _capacity;
    public LRUCache(int capacity)
    {
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (_frequency.TryGetValue(key, out var listNode))
        {
            _linkedList.Remove(listNode.Value);
            _linkedList.AddFirst(listNode);
            return listNode.Value.Value;
        }

        return -1;
    }
    
    public void Put(int key, int value) {
        if (_frequency.TryGetValue(key, out var existingNode))
        {
            existingNode.Value.Value = value;
            _linkedList.Remove(existingNode);
            _linkedList.AddFirst(existingNode);
        }
        else
        {
            if (_frequency.Count >= _capacity)
            {
                var lastNode = _linkedList.Last;
                if (lastNode != null)
                {
                    _linkedList.RemoveLast(); 
                    _frequency.Remove(lastNode.Value.Key);
                }
            }

            var listNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            _linkedList.AddFirst(listNode);
            _frequency[key] = listNode;
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