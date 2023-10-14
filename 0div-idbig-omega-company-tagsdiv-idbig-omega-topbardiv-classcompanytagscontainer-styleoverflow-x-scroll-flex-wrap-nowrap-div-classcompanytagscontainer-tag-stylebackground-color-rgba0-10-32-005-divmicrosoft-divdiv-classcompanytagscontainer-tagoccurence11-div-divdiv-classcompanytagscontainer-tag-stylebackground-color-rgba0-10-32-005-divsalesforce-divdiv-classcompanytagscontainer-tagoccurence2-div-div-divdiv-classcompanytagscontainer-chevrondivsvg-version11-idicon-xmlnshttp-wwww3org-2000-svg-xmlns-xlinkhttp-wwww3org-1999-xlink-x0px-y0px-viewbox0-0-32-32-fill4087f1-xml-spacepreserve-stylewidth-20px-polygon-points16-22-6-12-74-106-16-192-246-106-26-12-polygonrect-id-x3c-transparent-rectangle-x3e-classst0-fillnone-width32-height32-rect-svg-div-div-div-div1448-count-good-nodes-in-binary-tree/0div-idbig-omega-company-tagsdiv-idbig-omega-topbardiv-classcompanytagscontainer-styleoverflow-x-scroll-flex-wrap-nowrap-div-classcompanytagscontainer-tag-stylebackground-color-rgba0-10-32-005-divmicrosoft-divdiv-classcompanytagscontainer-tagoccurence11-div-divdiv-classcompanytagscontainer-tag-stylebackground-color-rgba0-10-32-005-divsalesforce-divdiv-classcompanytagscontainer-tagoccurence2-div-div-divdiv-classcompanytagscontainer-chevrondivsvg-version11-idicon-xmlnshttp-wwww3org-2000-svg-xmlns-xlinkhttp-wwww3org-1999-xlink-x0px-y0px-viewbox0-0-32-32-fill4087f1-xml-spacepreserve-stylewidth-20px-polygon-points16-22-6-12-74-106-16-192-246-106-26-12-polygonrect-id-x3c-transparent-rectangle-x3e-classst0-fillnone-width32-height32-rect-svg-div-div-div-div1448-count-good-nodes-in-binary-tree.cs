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
    int ans = 0;
    public int GoodNodes(TreeNode root) {
        GetCountGoodNodes(root, root.val, root.val);
        return ans;
    }
    
    public void GetCountGoodNodes(TreeNode node, int prevValue, int target){
        if(node == null)
            return;
        
        if( node.val >= prevValue && node.val >= target ){
            prevValue = node.val;
            ans++;
        }
        
        GetCountGoodNodes(node.left, prevValue, target);
        GetCountGoodNodes(node.right, prevValue, target);
    }
    
}