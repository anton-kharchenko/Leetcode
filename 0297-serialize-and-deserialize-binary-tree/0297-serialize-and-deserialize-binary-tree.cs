/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    private List<string> str { get; set; }
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
       str = new List<string>();
      void Dfs(TreeNode node){
        if(node == null){
            str.Add("N");
            return; 
        }
        str.Add(node.val.ToString() + "");
        Dfs(node.left);
        Dfs(node.right);
            
    }
        
    Dfs(root);
        
    return string.Join(",", str);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
    var arr = data.Split(",");
    var i = 0;
        
    TreeNode Dfs(){
        if(arr[i] == "N"){
            i++;
            return null;
        }
        var node = new TreeNode(int.Parse(arr[i]));
        i++;
        node.left = Dfs();
        node.right = Dfs();
        return node;
    }

    return Dfs();
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));