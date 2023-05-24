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
    List<int> list = new List<int>();
    public int RangeSumBST(TreeNode root, int low, int high) {
        int result = 0;
        PreOrder(root);
        foreach(var number in list){
            if(number>=low &&number<= high ){
                result+= number;
            }
        }
        return result;
    }
    
    public void PreOrder(TreeNode root){
        if(root == null){
            return;
        }
        
        list.Add(root.val);
        PreOrder(root.left);
        PreOrder(root.right);
    }

}