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
    List<int> result = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        Preorder(root);
        return result;
    }
    
    public void Preorder(TreeNode node){
        if(node == null) return;
        
        result.Add(node.val);
        Preorder(node.left);
        Preorder(node.right);
    }


}