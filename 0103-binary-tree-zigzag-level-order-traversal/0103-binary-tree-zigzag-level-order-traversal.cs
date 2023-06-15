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
        var result = new List<IList<int>>();
        if(root == null) return result;
        
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var reverse = false;
        
        while(q.Count>0){

            var list = new List<int>();
            var count = q.Count;
            for(var i = 0; i<count; i++){
                var node = q.Dequeue();
                 list.Add(node.val);
                  if(node.left != null) q.Enqueue(node.left);
                  if(node.right != null) q.Enqueue(node.right);
            }
            
            if(reverse){
                list.Reverse();
            }
                
            reverse = !reverse;
            result.Add(list);
        }
        
        return result;
    }
}