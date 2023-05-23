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
    List<int> res = new List<int>();
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        
        Traversal(root1);
        Traversal(root2);
         res.Sort();
        return res;
    }
    
    public void Traversal(TreeNode root){
        if(root == null){
            return;
        }
        
        res.Add(root.val);
        Traversal(root.left);
        Traversal(root.right);
    }
}