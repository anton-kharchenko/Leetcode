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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) return new TreeNode(val);
        var result = root;
        while(true){
            if(result.val <= val){
                if(result.right != null) {
                    result = result.right;
                }else{
                    result.right = new TreeNode(val);
                    break;
                }

            }else{
              if(result.left != null) {
                    result = result.left;
                }else{
                    result.left = new TreeNode(val);
                    break;
                }
            }
        }

        return root;
    }
}