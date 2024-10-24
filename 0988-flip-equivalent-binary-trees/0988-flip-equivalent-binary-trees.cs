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
    public bool FlipEquiv(TreeNode root1, TreeNode root2) {
        return Dfs(root1, root2);
    }

    public bool Dfs(TreeNode root1, TreeNode root2){
        if(root1==null || root2 == null){
            return root1 == root2;
        }
        if(root1.val != root2.val){
            return false;
        }
        return (Dfs(root1.left,  root2.right) && Dfs( root2.left,  root1.right))
        || (Dfs(root1.left,  root2.left) && Dfs( root1.right,   root2.right));
    }
}