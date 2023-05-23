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
     List<int> list = new List<int>();
    
    public bool IsUnivalTree(TreeNode root) {
        Traversal(root);
        for(var i =0; i<list.Count; i++){
            if(i+1<list.Count && list[i] != list[i+1]){
                return false;
            }
        }
        
        return true;
    }
    
    public void Traversal(TreeNode root){
        if(root == null){
            return;
        }
        
        list.Add(root.val);
        Traversal(root.left);
        Traversal(root.right);
    }
    
    
}