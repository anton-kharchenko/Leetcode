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
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        InOrder(result, root);
        return result;
    }
    
    public void InOrder(List<int> result, TreeNode node){
        if(node == null){
            return;
        }
        
        InOrder(result, node.left);
        result.Add(node.val);
        InOrder(result, node.right);
    }
}