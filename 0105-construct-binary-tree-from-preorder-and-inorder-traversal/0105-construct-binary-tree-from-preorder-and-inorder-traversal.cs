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

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Helper(inorder);
        
        TreeNode Helper(int[] inorder){
            if(inorder.Length <= 0 || inorder == null) return null;
            
            var first = preorder[0];
            var root = new TreeNode(first);
            
            preorder = preorder.Skip(1).ToArray();
            
            var index = Array.FindIndex(inorder, x=>x == first);
            
            var leftTree = inorder.Take(index).ToArray();
            var rightTree = inorder.Skip(index+1).ToArray();
            
            root.left = Helper(leftTree);
            root.right = Helper(rightTree);
            
            return root;
        }
        
        
    }
    
    
}