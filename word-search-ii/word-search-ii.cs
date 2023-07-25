public class Solution {
    Node root;
    HashSet<(int, int)> set = new HashSet<(int, int)>();
    HashSet<string> result = new HashSet<string>();
    
    public IList<string> FindWords(char[][] board, string[] words) {
        root = new Node();
        foreach(var word in words){
            AddWordToNode(word);
        }
        var n = board.Length;
        var m = board[0].Length;
        
        for(var i = 0; i<n; i++){
            for(var j = 0; j<m; j++){
                Dfs(i, j, n, m, board, root, "");
            }
        }
        
        return result.ToList();
    }
    
    
    public void Dfs(int i, int j, int n, int m, char[][] board, Node node, string word){
        if(i<0 || j<0|| i>=n||j>=m|| set.Contains((i, j)) ||!node.children.ContainsKey(board[i][j]) )
          return;
        
        word += board[i][j];
        
        set.Add((i, j));
        
        node = node.children[board[i][j]];
        
        if(node.IsWord)
            result.Add(word);
        
        Dfs(i+1, j, n, m, board, node, word);
        Dfs(i-1, j, n, m, board, node, word);
        Dfs(i, j+1, n, m, board, node, word);
        Dfs(i, j-1, n, m, board, node, word);
        
        set.Remove((i, j));
    }
    
    public void AddWordToNode(string word){
        var node = root;
        foreach(var c in word){
            if(!node.children.ContainsKey(c)){
                node.children[c] = new Node();
            }
            node = node.children[c];
        }
        
        node.IsWord = true;
    }
}

public class Node{
    public bool IsWord {get; set;}
    public Dictionary<char, Node> children;
    public Node(){
        children = new Dictionary<char, Node>();
    }
}
    
    
    


