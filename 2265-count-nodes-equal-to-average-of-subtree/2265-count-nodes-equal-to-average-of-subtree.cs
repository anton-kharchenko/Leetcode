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
    int count = 0;
    int total = 0;
    int ans = 0;
    public int AverageOfSubtree(TreeNode root) {
        if(root == null){
            return 0;
        }
        
        Traversal(root);
        
        if(total/count == root.val)  ans++;
        count = 0;
        total = 0;
        AverageOfSubtree(root.left);
        AverageOfSubtree(root.right);
        return ans;
    }
    
    public void Traversal(TreeNode root){
        if(root == null){
            return;
        }
        count++;
        total += root.val;
        Traversal(root.left);
        Traversal(root.right);

    }
}