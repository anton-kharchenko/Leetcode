public class Trie {
    Node root;
    public Trie()
    {
        root = new Node();
    }

    public void Insert(string word)
    {
        var node = root;
        foreach(var c in word){
            if(!node.Children.ContainsKey(c)){
                node.Children.Add(c, new Node());
            }
            node = node.Children[c];
        }
        
        node.IsWord = true;
    }

    public bool Search(string word)
    {
        var node = root;
        
        foreach(var c in word){
            if(!node.Children.ContainsKey(c)){
                return false;
            }
            node = node.Children[c];
        }
        
        return node.IsWord;
    }

    public bool StartsWith(string prefix)
    {
        var node = root;
        
        foreach(var c in prefix){
            if(!node.Children.ContainsKey(c)){
                return false;
            }
            node = node.Children[c];
        }
        
        return true;
    }
}

public class Node{
    public Dictionary<char, Node> Children;
    public bool IsWord {get; set;}
    public Node(){
        Children = new  Dictionary<char, Node>();
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */