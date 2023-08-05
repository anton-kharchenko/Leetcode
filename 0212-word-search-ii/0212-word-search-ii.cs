public class Solution {
    public Node root;
    public HashSet<string> ans = new HashSet<string>();
    public HashSet<(int, int)> visited = new HashSet<(int, int)>();
    int n = 0;
    int m = 0;
    
    public IList<string> FindWords(char[][] board, string[] words) {
        root = new Node();
        n = board.Length;
        m = board[0].Length;
        
        foreach(var word in words){
            AddWord(word);
        }
        
        for(var i = 0; i<n; i++){
            for(var j = 0; j<m; j++){
                Dfs(i, j, board, root, "");
            }
        }
        
        return ans.ToList();
    }
    
    
    public void Dfs(int i, int j, char[][] board, Node node, string word){
        if(i<0|| j<0 || i>=n || j>=m || !node.Children.ContainsKey(board[i][j]) || visited.Contains((i, j))){
            return;
        }
        
        word += board[i][j];
        visited.Add((i,j ));
        node = node.Children[board[i][j]];
        
        if(node.IsWord){
            ans.Add(word);
        }
        
        Dfs(i+1, j, board, node, word);
        Dfs(i-1, j, board, node, word);
        Dfs(i, j+1, board, node, word);
        Dfs(i, j-1, board, node, word);
        
        visited.Remove((i, j));
        
    }
    
    public void AddWord(string word){
        var node = root;
        
        foreach(var letter in word){
            if(!node.Children.ContainsKey(letter)){
                node.Children[letter] = new Node();
            }
            node = node.Children[letter];
        }
        
        node.IsWord = true;
    }
    
}

public class Node{
    public bool IsWord {get; set;}
    public Dictionary<char, Node> Children;
    
    public Node(){
        Children = new Dictionary<char, Node>();
    }
}



    
    
    


