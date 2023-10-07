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
     public bool IsSubtree(TreeNode s, TreeNode t) 
    {
        if(s == null)
            return false;
         if(s.val == t.val){
             if(Dfs(s, t)){
                 return true;
             }
         }
         
         return IsSubtree(s.left, t) || IsSubtree(s.right, t);
    }
    
    public bool Dfs(TreeNode p, TreeNode q){
        if(p == null && q == null){
            return true;
        }
        if((p == null && q!= null) || (p != null  && q == null)){
            return false;
        }
        
        if(p.val != q.val){
            return false;
        }
        
        
        return Dfs(p.left, q.left) && Dfs(p.right, q.right);
    }
}