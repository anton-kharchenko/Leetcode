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
    int temp = 0;
    bool flag = false;
    
    public bool HasPathSum(TreeNode root, int targetSum) {
        Dfs(root, targetSum);
        return flag;
    }
    
    public void Dfs(TreeNode node,  int sum){
        if(flag){
            return;
        }
        
        if(node == null){
            return;
        }
        
        temp += node.val;
        
        if(node.left == null && node.right == null){
            if(temp == sum){
                flag = true;       
            }
        }
        
        Dfs(node.left, sum);
        Dfs(node.right, sum);
           
        
        temp -= node.val;
    }
}