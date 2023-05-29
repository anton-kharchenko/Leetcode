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
    
    
    public int PathSum(TreeNode root, int targetSum) {
        if (root is null) return 0;    
        return DFS(root, ref targetSum, 0) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
    }

    public int DFS(TreeNode root, ref int targetSum, long currSum) {
        if (root is null) return 0;
        currSum += root.val;
        int res = DFS(root.left, ref targetSum, currSum) + DFS(root.right, ref targetSum, currSum);
        return currSum == targetSum ? 1 + res : res;
    }
    
}

// 