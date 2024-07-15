public class LRUCache
{
    private int _capacity;
    private Dictionary<int, LinkedListNode<CacheItem>> map;
    private LinkedList<CacheItem> items;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        map = new(_capacity);
        items = new LinkedList<CacheItem>();
    }

    public int Get(int key)
    {
        if (map.TryGetValue(key, out var node))
        {
            items.Remove(node);
            items.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (map.TryGetValue(key, out var node))
        {
            node.Value.Value = value;
            items.Remove(node);
            items.AddFirst(node);
        }
        else
        {
            if (_capacity <= map.Count)
            {
                var lastNode = items.Last;
                items.RemoveLast();
                map.Remove(lastNode.Value.Key);
            }

            var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            items.AddFirst(newNode);
            map.Add(key, newNode);
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