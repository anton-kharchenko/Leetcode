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
    public TreeNode[] SplitBST(TreeNode root, int target) {
         var result = new TreeNode[2];
         result[0] = BuildMinTree(root, target, null);
         result[1] = BuildMaxTree(root, target, null);
         return result;
    }

    public TreeNode BuildMaxTree(TreeNode node, int target, TreeNode newNode){
        if(node == null){
            return  null;
        }

        if(node.val <= target){
            return BuildMaxTree(node.right, target, newNode);
        }

        newNode = new TreeNode(node.val);
        newNode.left = BuildMaxTree(node.left, target, newNode.left);
        newNode.right = BuildMaxTree(node.right, target, newNode.right);
        return newNode;
    }
    

        public TreeNode BuildMinTree(TreeNode node, int target, TreeNode newNode){
        if(node == null){
            return  null;
        }

        if(node.val > target){
            return BuildMinTree(node.left, target, newNode);
        }

        newNode = new TreeNode(node.val);
        newNode.left = BuildMinTree(node.left, target, newNode.left);
        newNode.right = BuildMinTree(node.right, target, newNode.right);
        return newNode;
    }
}