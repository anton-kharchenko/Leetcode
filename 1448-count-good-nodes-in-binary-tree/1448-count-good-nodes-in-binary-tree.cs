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
    int result = 0;
    public int GoodNodes(TreeNode root) {
        if(root.left == null & root.right == null) return 1;
        Dfs(root, root.val, root.val);
        return result;
    }
    
    public void Dfs(TreeNode node, int rootVal, int prev){
        if(node ==null) return;
        
        if(rootVal <= node.val && prev <=node.val){
            result++;
            prev = node.val;
        }
        
        Dfs(node.left, rootVal, prev);
        Dfs(node.right, rootVal, prev);
    }
}