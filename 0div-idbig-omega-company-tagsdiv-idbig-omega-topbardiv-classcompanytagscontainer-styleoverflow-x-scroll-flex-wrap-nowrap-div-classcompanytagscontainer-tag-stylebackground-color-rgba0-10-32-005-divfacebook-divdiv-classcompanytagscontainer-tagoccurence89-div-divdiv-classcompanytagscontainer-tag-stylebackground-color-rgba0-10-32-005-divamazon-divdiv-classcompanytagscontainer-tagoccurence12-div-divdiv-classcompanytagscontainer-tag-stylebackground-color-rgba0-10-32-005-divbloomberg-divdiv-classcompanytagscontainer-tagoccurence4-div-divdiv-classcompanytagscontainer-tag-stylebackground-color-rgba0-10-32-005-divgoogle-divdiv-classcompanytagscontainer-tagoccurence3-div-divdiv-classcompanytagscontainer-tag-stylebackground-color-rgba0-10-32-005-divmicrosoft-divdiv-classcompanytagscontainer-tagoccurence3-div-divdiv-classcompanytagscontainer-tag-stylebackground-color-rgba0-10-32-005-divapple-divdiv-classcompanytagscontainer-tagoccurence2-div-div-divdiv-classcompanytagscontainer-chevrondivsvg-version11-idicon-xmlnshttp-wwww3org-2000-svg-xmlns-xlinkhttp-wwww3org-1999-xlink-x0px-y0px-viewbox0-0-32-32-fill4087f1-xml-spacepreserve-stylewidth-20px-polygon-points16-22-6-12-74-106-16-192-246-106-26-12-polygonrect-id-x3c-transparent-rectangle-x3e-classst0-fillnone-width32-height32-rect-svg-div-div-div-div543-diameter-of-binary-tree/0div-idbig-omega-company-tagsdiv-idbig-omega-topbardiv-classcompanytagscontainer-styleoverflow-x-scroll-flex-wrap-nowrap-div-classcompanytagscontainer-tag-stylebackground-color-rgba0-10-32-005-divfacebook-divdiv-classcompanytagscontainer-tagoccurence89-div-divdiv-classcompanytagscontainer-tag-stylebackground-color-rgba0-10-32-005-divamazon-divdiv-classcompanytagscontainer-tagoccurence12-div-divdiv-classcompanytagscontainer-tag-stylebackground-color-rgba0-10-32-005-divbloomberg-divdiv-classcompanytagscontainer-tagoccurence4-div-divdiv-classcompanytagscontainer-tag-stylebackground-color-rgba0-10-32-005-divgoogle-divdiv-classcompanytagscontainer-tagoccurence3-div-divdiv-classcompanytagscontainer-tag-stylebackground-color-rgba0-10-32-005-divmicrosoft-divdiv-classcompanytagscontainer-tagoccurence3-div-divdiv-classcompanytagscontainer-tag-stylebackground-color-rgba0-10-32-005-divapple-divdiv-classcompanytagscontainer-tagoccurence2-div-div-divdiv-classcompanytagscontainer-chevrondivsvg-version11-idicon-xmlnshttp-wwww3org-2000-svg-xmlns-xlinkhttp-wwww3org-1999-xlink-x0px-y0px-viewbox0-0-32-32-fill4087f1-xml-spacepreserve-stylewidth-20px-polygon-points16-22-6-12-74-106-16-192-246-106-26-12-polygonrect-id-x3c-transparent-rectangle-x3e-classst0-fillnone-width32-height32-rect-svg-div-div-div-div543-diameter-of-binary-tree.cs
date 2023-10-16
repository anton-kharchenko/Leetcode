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
        int maxDiameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        GetMaxDepth(root);
        return maxDiameter;
    }

    public int GetMaxDepth(TreeNode root){
        if(root == null) return 0;
        int leftPath =  GetMaxDepth(root.left);
        int rightPath = GetMaxDepth(root.right);
        maxDiameter = Math.Max(maxDiameter, leftPath + rightPath);
        return 1 + Math.Max(leftPath, rightPath);
    }
}