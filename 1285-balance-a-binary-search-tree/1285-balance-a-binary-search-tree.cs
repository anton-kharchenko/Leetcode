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
    List<int> nodes;
    public TreeNode BalanceBST(TreeNode root) {
        if(root is null) return null;
        nodes = new List<int>();
        Traverse(root);
        return Build(null, 0, nodes.Count - 1);
    }

    public void Traverse(TreeNode node){
        if(node is null) return;
        Traverse(node.left);
        nodes.Add(node.val);
        Traverse(node.right);
    }

    public TreeNode Build(TreeNode node, int start, int end){
        if(start > end){
            return null;
        }

        var mid = start + (end - start) / 2;
        node = new TreeNode(nodes[mid]);
        node.left = Build(node.left, start, mid - 1);
        node.right = Build(node.right, mid + 1, end);
        return node;
    }
}