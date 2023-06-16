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
            
        Dfs(root, root.val, root.val);
        return result;
    }
    
    public void Dfs(TreeNode node, int target, int prev){
        if(node == null){
            return; 
        }
        
        if(node.val >= target && node.val >= prev){
            result++;
            prev = node.val;
        }
        
        Dfs(node.left, target, prev);
        Dfs(node.right, target, prev);
    }
}