public class Solution {
    public Node _root;
    public IList<string> FindWords(char[][] board, string[] words) {
        _root = new Node();
        foreach(var word in words){
            AddNewWordToTrie(word);
        }
        
        var n = board.Length;
        var m = board[0].Length;
        var res = new HashSet<string>();
        var set = new HashSet<(int, int)>();
        
        for(var i = 0; i<n; i++){
            for(var j = 0; j<m;j++){
                Dfs(board, i, j, n, m, set, "", _root, res);
            }
        }
        return res.ToList();
    }
    
    
    
    public void Dfs(char[][] board, int i, int j,  int n,  int m, HashSet<(int, int)> set, string word, Node root, HashSet<string> res){
        if(i<0 || j <0 || i>=n || j>= m || set.Contains((i, j)) || !root._children.ContainsKey(board[i][j]))
        {
           return;    
        }
        
        set.Add((i, j));
        
        word += board[i][j];
        
        root = root._children[board[i][j]];
        
        if(root.IsWord){
            res.Add(word);
        }
            
        Dfs(board, i+1, j, n, m, set, word, root, res);    
        Dfs(board, i-1, j, n, m, set, word, root, res);    
        Dfs(board, i, j+1, n, m, set, word, root, res);
        Dfs(board, i, j-1, n, m, set, word, root, res);
        set.Remove((i, j));
    }
    
    public void AddNewWordToTrie(string word){
        var node = _root;
        
        foreach(var c in word){
            if(!node._children.ContainsKey(c)){
                node._children[c] = new Node();
            }
            
            node = node._children[c];
        }
        
        node.IsWord = true; 
        
    }
}

public class Node{
    public Dictionary<char, Node> _children;
    public bool IsWord {get; set;}
    public Node(){
        _children = new Dictionary<char, Node>();
    }
}