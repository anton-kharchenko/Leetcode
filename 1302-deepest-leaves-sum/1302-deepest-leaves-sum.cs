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
    
    public int DeepestLeavesSum(TreeNode root) {
   
     if(root == null) return 0;   
    Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while(q.Count != 0){
            var sum = 0;
            var size = q.Count;
            
            for(var i =0; i<size; i++){
                var node = q.Dequeue();
                sum += node.val;
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
            
            if(q.Count == 0){
                return sum;
            }
        }
        
        return 0;
        
    }
}