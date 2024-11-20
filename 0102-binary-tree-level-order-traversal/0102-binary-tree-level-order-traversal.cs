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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        var result = new List<IList<int>>();
        if(root == null) return result;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var size = queue.Count;
            var list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                list.Add(node.val);
            }
            result.Add(list);
        }
        return result;
    }
}