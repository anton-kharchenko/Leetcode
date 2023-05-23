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
    List<int> numbers = new List<int>();
    public TreeNode BalanceBST(TreeNode root) {
        Inorder(root);
        numbers.Sort();
        return BuildTree(numbers);
    }
    
    public void Inorder(TreeNode root){
        if(root == null){
            return;
        }
        numbers.Add(root.val);
        Inorder(root.left);
        Inorder(root.right);
    }
    
    public TreeNode BuildTree(List<int> numbers){
        if(numbers.Count == 0){
            return null;
        }
        
        var mid = numbers.Count / 2;
        var root = new TreeNode(numbers[mid]);
        root.left = BuildTree(numbers.Take(mid).ToList()); 
         root.right = BuildTree(numbers.Skip(mid+1).ToList()); 
        
        return root;
    }
}