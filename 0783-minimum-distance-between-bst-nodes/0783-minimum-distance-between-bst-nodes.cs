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
    public int MinDiffInBST(TreeNode root) {
        Traversal(root);
        list.Sort();
        if(list.Count==2) return list[1] - list[0]; 
        var min = list[1] - list[0];
    
        for(var i = 0; i<list.Count -1;i++){
            if(list[i+1] - list[i]<min){
                min = list[i+1] - list[i];
            }
        }
        
        return min;
    }
    
    public void Traversal(TreeNode node){
        if(node == null) return;
        list.Add(node.val);
        Traversal(node.left);
        Traversal(node.right);
    }
}