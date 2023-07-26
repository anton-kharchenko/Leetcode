public class Solution {
    HashSet<(int, int)> visited = new HashSet<(int, int)>();
    HashSet<string> result = new HashSet<string>();
    Node root = new Node();
    
    public IList<string> FindWords(char[][] board, string[] words) {
        var node = root;
        foreach(var word in words){
            AddWord(word);
        }
        
        var n = board.Length;
        var m = board[0].Length;
        
        for(var i = 0; i<n; i++){
            for(var j = 0; j<m; j++){
                Dfs(i, j, n, m, node, "", board);
            }
        }
        
        return result.ToList();
    }
    
    public void Dfs(int i, int j, int n, int m, Node node, string word, char[][] board){
        
        if(i<0||j<0|| i>=n|| j>=m|| visited.Contains((i, j)) || !node.children.ContainsKey(board[i][j])){
            return;
        }
        
        visited.Add((i, j));
        
        word += board[i][j];
        
        node = node.children[board[i][j]];
        
        if(node.IsWord){
            result.Add(word);
        }
        
        Dfs(i+1, j, n, m, node, word, board);
        Dfs(i-1, j, n, m, node, word, board);         
        Dfs(i, j+1, n, m, node, word, board);
        Dfs(i, j-1, n, m, node, word, board);
        
        visited.Remove((i, j));
    }
    
    public void AddWord(string word){
        var node = root;
        
        foreach(var letter in word){
            if(!node.children.ContainsKey(letter)){
                node.children[letter] = new Node();
            }
            node = node.children[letter];
        }
        
        node.IsWord = true;
        
    }
       
}

public class Node{
    public bool IsWord {get; set;}
    public Dictionary<char, Node> children;
    
    public Node(){
        children  = new Dictionary<char, Node>();
    }
}

    
    
    


