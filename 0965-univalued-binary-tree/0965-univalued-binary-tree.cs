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
  
    
    public bool IsUnivalTree(TreeNode root) {
        if(root== null){
            return true;
        }
        
        return Halper(root, root.val);
    }
    
    public bool Halper(TreeNode root, int val){
        if(root == null){
            return true;
        }
        
        return root.val == val && Halper(root.left, val) && Halper(root.right, val);
    }
    
    
}