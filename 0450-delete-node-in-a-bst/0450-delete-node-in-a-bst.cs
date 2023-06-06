/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    List<int> _list = new List<int>();
    public TreeNode DeleteNode(TreeNode root, int key) {
        Traversal(root);
        _list.Sort();
        _list.Remove(key);
        return Build(0, _list.Count - 1);
    }

    private void Traversal(TreeNode node){
        if(node == null) return;
        _list.Add(node.val);
        Traversal(node.left);
        Traversal(node.right);
    }
    
     private TreeNode Build(int l, int r){
         if (l> r) {
              return null;
         }
        var mid = (r+l) / 2;
        var node = new TreeNode(_list[mid]);
        node.left = Build(l, mid-1);
        node.right = Build(mid+1, r);
        return node;
    }
}