/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Codec {
    // Encodes a tree to a single string.
    public string serialize(Node root) {
        if(root == null){
            return "";
        }
        var res = "" + root.val;
        res += "," + root.children.Count;
        for (var i = 0; i<root.children.Count; i++)
        {
            res += "," + serialize(root.children[i]);
        }
        return res;
        
    }
	
    // Decodes your encoded data to tree.
    public Node deserialize(string data) {
        if(string.IsNullOrWhiteSpace(data)){
            return null;
        }
        var i = new int[1];
        return Helper(data.Split(",").ToArray(), i);
    }
    
    public Node Helper(string[] data, int[] node){
        if(data.Length == node[0]){
            return null;
        }
        
        var number = data[node[0]++];
        
        if(number == "*"){
            return null;
        }
        var root = new Node(int.Parse(number), new List<Node>());
        var countOfChildren = Convert.ToInt32(data[node[0]++]);   
        
        for(var i = 0; i< countOfChildren; i++){
            var child = Helper(data, node);
            
            if(child!=null){
                root.children.Add(child);
            }
        }
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));