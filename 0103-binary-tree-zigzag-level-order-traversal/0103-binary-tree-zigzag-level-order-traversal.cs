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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var levels = new List<IList<int>>();
        
        if(root == null) return new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var reversed = false;
        
        while(queue.Count != 0){
            var list = new List<int>();
            var count = queue.Count;
            for(var i = 0; i<count; i++){
                var node = queue.Dequeue();
                list.Add(node.val);
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            
            if(reversed){
                list.Reverse();
            }
            
            reversed = !reversed;
            levels.Add(list);
        }
        
        
        return levels;
    }
}