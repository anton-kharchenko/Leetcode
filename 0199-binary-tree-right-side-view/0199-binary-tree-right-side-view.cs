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
    List<int> result = new List<int>();
    public IList<int> RightSideView(TreeNode root) {
        Dfs(root, 1);
        return result;
    }
    
    public void Dfs(TreeNode node, int level){
        if(node == null) return;
        
        if(level > result.Count){
            result.Add(node.val);
        }
        
        Dfs(node.right, level + 1);
        Dfs(node.left, level + 1);
    }

}