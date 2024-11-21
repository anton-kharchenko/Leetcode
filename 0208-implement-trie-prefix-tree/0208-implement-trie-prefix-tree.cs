public class Trie
{
    private Node root = new();
    public Trie()
    {
    }
    
    public void Insert(string word)
    {
        var node = root;
        foreach (var letter in word)
        {
            node.children.TryAdd(letter, new Node());
            node = node.children[letter];
        }

        node.isWord = true;
    }
    
    public bool Search(string word) {
        var node = root;
        foreach (var letter in word)
        {
            if (!node.children.TryGetValue(letter, out var child)) return false;
            node = child;
        }
        
        return node.isWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = root;
        foreach (var letter in prefix)
        {
            if (!node.children.TryGetValue(letter, out var child)) return false;
            node = child;
        }
        
        return true;
    }
}

public class Node{
    public Dictionary<char, Node> children;
    public bool isWord;
    public Node(){
        children = new Dictionary<char, Node>();
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */