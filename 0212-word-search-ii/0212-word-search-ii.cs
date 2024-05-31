public class Solution {
    Node root;
    public IList<string> FindWords(char[][] board, string[] words) {
        root = new Node();
        var result = new HashSet<string>();
        foreach(var word in words){
            AddWord(word);
        }
        var visited = new HashSet<(int, int)>();

        for(var i = 0; i<board.Length; i++){
            for(var j = 0; j<board[0].Length; j++){
                Dfs(i, j, board.Length, board[0].Length, board, visited, "", root, result);
            }
        }

        return result.ToArray();
    }


    public void Dfs(int row, int col, int rows, int cols, char[][] board, 
    HashSet<(int, int)> visited, string word, Node node, HashSet<string> result){
        if(row>=rows||col>=cols || row<0 || col<0 || !node.Children.ContainsKey(board[row][col]) ||
        visited.Contains((row, col))){
            return;
        }

        visited.Add((row, col));
        word += board[row][col];
        node = node.Children[board[row][col]];
        if(node.IsWord){
            result.Add(word);
        }
        Dfs(row + 1, col, rows, cols, board, visited, word, node, result);
        Dfs(row - 1, col, rows, cols, board, visited, word, node, result);
        Dfs(row, col + 1, rows, cols, board, visited, word, node, result);
        Dfs(row, col - 1, rows, cols, board, visited, word, node, result);
        visited.Remove((row, col));
    }

    public void AddWord(string word){
        Node node = root;
        foreach(var letter in word){
            node.Children.TryAdd(letter, new Node());
            node = node.Children[letter];
        }
        node.IsWord = true;
    }  
}

public class Node{
    public bool IsWord;
    public Dictionary<char, Node> Children;
    public Node(){
        Children = new Dictionary<char, Node>();
    }
}

    