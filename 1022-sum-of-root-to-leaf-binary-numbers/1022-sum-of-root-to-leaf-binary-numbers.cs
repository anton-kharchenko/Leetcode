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
    
    public int SumRootToLeaf(TreeNode root) {
        
        Preorder(root, string.Empty);
        
        return total;
    }
    
    public void Preorder(TreeNode root, string binary){
        if(root is null){
            return;
        }
        
        
        Preorder(root.left, binary + root.val.ToString());
        Preorder(root.right, binary + root.val.ToString());
        
        if(root.left is null && root.right is null){
            total += Convert.ToInt32(binary + root.val.ToString(), 2);
        }
    }
}