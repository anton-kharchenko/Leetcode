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
    public IList<int> RightSideView(TreeNode root) {
        var rightSideValueList = new List<int>();
        FillList(root, rightSideValueList, 1);
        return rightSideValueList;
    }
    
    public void FillList(TreeNode node, List<int> list, int level){
        if(node == null)
            return;
        
        if(level > list.Count){
            list.Add(node.val);
        }
        
        FillList(node.right, list, level+1);
        FillList(node.left, list, level+1);
    }
}