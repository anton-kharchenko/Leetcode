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
  public bool IsBalanced(TreeNode root) {
    return Dfs(root) != -1;
}
    
    public int Dfs(TreeNode root){
        if(root == null){
            return 0;
        }
        var left = Dfs(root.left);
        if(left == - 1) return -1;
        var right = Dfs(root.right);
        if(right == - 1) return -1;
        if(Math.Abs(left - right) > 1) return -1;
        return 1 + Math.Max(left, right);
    }
}