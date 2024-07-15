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
public class Solution
{
    public TreeNode CreateBinaryTree(int[][] descriptions)
    {
        Dictionary<int, TreeNode> nodeMap = new Dictionary<int, TreeNode>();
        Dictionary<int, int> childToParentMap = new Dictionary<int, int>();

        foreach (var description in descriptions) {
            int parent = description[0];
            int child = description[1];
            int isLeft = description[2];

            if (!nodeMap.ContainsKey(parent)) {
                nodeMap[parent] = new TreeNode(parent);
            }
            TreeNode parentNode = nodeMap[parent];

            if (!nodeMap.ContainsKey(child)) {
                nodeMap[child] = new TreeNode(child);
            }
            TreeNode childNode = nodeMap[child];

            if (isLeft == 1) {
                parentNode.left = childNode;
            } else {
                parentNode.right = childNode;
            }

            childToParentMap[child] = parent;
        }
        
        foreach (var description in descriptions) {
            int parent = description[0];
            if (!childToParentMap.ContainsKey(parent)) {
                return nodeMap[parent];
            }
        }

        return null;
    }
}
   