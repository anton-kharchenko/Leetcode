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
    int total = 0; 
    public TreeNode BstToGst(TreeNode root) {
        Traversal(root);
        return root;
    }
    
    public void Traversal(TreeNode root){
        if(root == null){
            return;
        }
        
        Traversal(root.right);
        root.val += total;
        total = root.val;
        Traversal(root.left);

    }
}