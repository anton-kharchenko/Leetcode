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
    List<IList<string>> res = new List<IList<string>>();

    public IList<IList<string>> PrintTree(TreeNode root)
    {
        var height = CalculateHeight(root);
        var rows = height;
        var cols = 1;

        for (int i = 1; i < height; i++)
                cols = cols * 2 + 1;
        
        for (var i = 0; i < rows; i++)
        {
            res.Add(new List<string>());
            for (var j = 0; j < cols; j++)
            {
                res[i].Add("");
            }
        }

        var low = 0;
        var high = cols;
        Dfs(root, 0, low, high);
        return res;
    }

    public void Dfs(TreeNode node, int rowCounter, int low, int high)
    {
        if (node == null)
            return;

        var mid = (low + high) / 2;
        res[rowCounter][mid] = node.val.ToString();

        Dfs(node.left, rowCounter + 1, low, mid - 1);
        Dfs(node.right, rowCounter + 1, mid + 1, high);
    }

    public int CalculateHeight(TreeNode node)
    {
        if (node == null) 
            return 0;
        
        var left = CalculateHeight(node.left);
        var right = CalculateHeight(node.right);
        return Math.Max(left, right) + 1;
    }
}