public class Trie {
 public Node root = null;

    public Trie()
    {
        root = new Node();
    }

    public void Insert(string word)
    {
        var node = root;
        foreach(var i in word){
            if(!node.children.ContainsKey(i)){
                node.children[i] =  new Node();
            }
           node = node.children[i];
        }
        node.word = true;
    }

    public bool Search(string word)
    {
        var node = root;
        foreach(var i in word){
            if(!node.children.ContainsKey(i)){
                return false;
            }
            node = node.children[i];
        }
        return node.word;
    }

    public bool StartsWith(string prefix)
    {
        var node = root;
        foreach(var i in prefix){
            if(!node.children.ContainsKey(i)){
                return false;
            }
            node = node.children[i];
        }

        return true;
    }
}

public class Node{
    public bool word {get; set;}
    public Dictionary<char, Node> children {get; set;}
    
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