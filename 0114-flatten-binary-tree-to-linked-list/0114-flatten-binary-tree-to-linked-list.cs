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
    public void Flatten(TreeNode root) {
        PreOrder(root);
        
        for(var i = 1; i<list.Count; i++){
            root.left = null;
            root.right = new TreeNode(list[i]);
            root = root.right;
        }
    }
    
    public void PreOrder(TreeNode node){
        if(node == null){
            return;
        }
        
        list.Add(node.val);
        PreOrder(node.left);
        PreOrder(node.right);
    }
}