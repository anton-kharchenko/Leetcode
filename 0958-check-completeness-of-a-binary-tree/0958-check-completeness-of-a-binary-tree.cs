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
    public bool IsCompleteTree(TreeNode root) {
        if(root == null) return false;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count> 0){
            var node = q.Dequeue();
            if(node != null){
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }else{
                while(q.Count>0){
                    var n = q.Dequeue();
                    if(n!= null){
                        return false;
                    }
                }
            }
        }
        
        return true;
    }
    
   
}