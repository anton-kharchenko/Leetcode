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
    public bool IsValidBST(TreeNode root) {
        return IsBST(root, long.MinValue, long.MaxValue);
    }

    public bool IsBST(TreeNode node, long min, long max){
        if(node is null){
            return true;
        }

        if(node.val <= min || node.val >= max){
            return false;
        }

        var left = IsBST(node.left, min, node.val);
        var right = IsBST(node.right, node.val, max);
        return left && right;
    }
}