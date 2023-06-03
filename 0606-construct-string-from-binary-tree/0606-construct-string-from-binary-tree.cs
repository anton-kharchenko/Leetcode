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
 
    public string Tree2str(TreeNode root) {
        return BuildString(root);
    }
    
    public string BuildString(TreeNode root){
        var sb = new StringBuilder();
        sb.Append(root.val);
        if(root.left!=null){
            sb.Append('(');
            sb.Append(BuildString(root.left));
            sb.Append(')');
        }
        if(root.right!=null){
            if(root.left == null){
                sb.Append("()");
            }
            
            sb.Append('(');
            sb.Append(BuildString(root.right));
            sb.Append(')');
        }
        
        return sb.ToString();
    }
}

