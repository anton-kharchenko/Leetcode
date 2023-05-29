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
    List<int> lst = new List<int>();
    public void Flatten(TreeNode root) {
        Traversal(root);
     
        
        for(var i = 1; i<lst.Count; i++){
            root.left = null;
            root.right = new TreeNode(lst[i]);
            root = root.right;
        }
    }
    
    public void Traversal(TreeNode node){
        if(node == null){
            return;
        }
        
        lst.Add(node.val);
        Traversal(node.left);
        Traversal(node.right);
    }
    
}