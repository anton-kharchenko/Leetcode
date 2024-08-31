using System.Text;
public class Solution
{
    private Node root = new();
    public string LongestCommonPrefix(string[] strs) {
        foreach (var str in strs)
            AddWord(str);
        
        var result = new StringBuilder();
        var firstWord = strs[0];
        
        foreach (var letter in firstWord)
        {
            if (root.IsWord || root.Children.Count > 1) 
                break;
            
            result.Append(letter);
            root = root.Children[letter];
        }

        return result.ToString();
    }

    private void AddWord(string word)
    {
        var node = root;
        foreach (var letter in word)
        {
            node.Children.TryAdd(letter, new Node());
            node = node.Children[letter];
        }
        
        node.IsWord = true;
    }
}

public class Node{
    public Node()
    {
        Children = new Dictionary<char, Node>();
    }

    public bool IsWord { get; set; }
    public Dictionary<char, Node> Children { get; set; }
}