public class Solution {
    Node root = new Node();
    public IList<string> FindWords(char[][] board, string[] words) {
        foreach(var w in words){
            Add(w);
        }
        
        var result = new HashSet<string>();
        var n = board.Length;
        var m = board[0].Length;
        var visited = new HashSet<(int, int)>();
        
        for(var i =0; i<n; i++){
            for(var j = 0; j<m;j++){
                Dfs(i, j, root, "", visited, board, n, m, result);
            }
        }
        
        return result.ToList();
    }
    
    
    public void Dfs(int r, int c, Node node, string word, HashSet<(int, int)> visited, char[][] board, int n, int m, HashSet<string> result){
        if(r<0||c<0||r>=n || c>=m|| visited.Contains((r, c)) || !node.Children.ContainsKey(board[r][c])){
            return;
        }
        
        visited.Add((r, c));
        node = node.Children[board[r][c]];
        word += board[r][c];
        
        if(node.IsWord){
            result.Add(word);
        }
        
        Dfs(r+1,c,node, word, visited, board, n,m, result);
        Dfs(r-1,c,node, word, visited, board, n,m, result);
        Dfs(r,c+1,node, word, visited, board, n,m, result);
        Dfs(r,c-1,node, word, visited, board, n,m, result);
        visited.Remove((r, c));
    }
    
    
    public void Add(string word){
            var node = root;
            foreach(var c in word){
            if(!node.Children.ContainsKey(c)){
                    node.Children[c] = new Node();
            }
                 node = node.Children[c];
                 
            }
            
            node.IsWord = true;
    }
    
}



public class Node{
        public bool IsWord{get; set;}
        public Dictionary<char, Node> Children {get;set;}
        
        public Node(){
            Children = new  Dictionary<char, Node>();
        }
        
    }