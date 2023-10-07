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
    public int MaxDepth(TreeNode root) {
       return root == null ? 0 : Math.Max( 1 + MaxDepth(root.left),  1 + MaxDepth(root.right));
    }
    
    // public int Dfs(TreeNode node){
    //     if(node == null){
    //         return 0;
    //     }
    //   var left =  1 + Dfs(node.left);
    //   var right = 1 + Dfs(node.right);
    //     return Math.Max(left, right);
    // }
}