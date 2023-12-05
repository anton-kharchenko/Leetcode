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
    int maxPath = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        CalculateMathPath(root); 
        return maxPath;
    }
    private int CalculateMathPath(TreeNode node){ 
        if(node == null){
            return 0;
        }
        int leftSum = Math.Max(0, CalculateMathPath(node.left));
        int rightSum = Math.Max(0, CalculateMathPath(node.right));
        maxPath = Math.Max(maxPath, leftSum + rightSum + node.val); 
        return Math.Max(leftSum, rightSum) + node.val;
    }
}