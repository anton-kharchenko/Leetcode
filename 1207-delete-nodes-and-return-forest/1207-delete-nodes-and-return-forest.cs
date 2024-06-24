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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        var result = new List<TreeNode>();
        var toDelete = to_delete.ToHashSet();
        DelNodesDfs(ref root, true);
        return result;
        
        void DelNodesDfs(ref TreeNode node, bool isRoot)
        {
            if (node != null)
            {
                var deleted = toDelete.Contains(node.val);
                DelNodesDfs(ref node.left, deleted);
                DelNodesDfs(ref node.right, deleted);

                if (deleted)
                {
                    node = null;
                }
                else if(isRoot)
                {
                    result.Add(node);
                }
            }
        }
    }
    
}