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
    
    public int KthSmallest(TreeNode root, int k) {
        AddValue(root);
        list.Sort();
        return list[k-1];
    }

    public void AddValue(TreeNode node){
        if(node == null){
            return;
        }
        
        AddValue(node.left);
        list.Add(node.val);
        AddValue(node.right);
    }


}