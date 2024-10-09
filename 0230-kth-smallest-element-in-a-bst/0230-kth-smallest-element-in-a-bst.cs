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
    public int KthSmallest(TreeNode root, int k)
    {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x,y)=>y.CompareTo(x)));
        Dfs(root, k, pq);
        return pq.Peek();
    }

    public void Dfs(TreeNode root, int k, PriorityQueue<int, int> pq)
    {
        if(root is null) return;
        
        pq.Enqueue(root.val, root.val);
        if (pq.Count > k)
        {
            pq.Dequeue();
        }

        Dfs(root.left, k, pq);
        Dfs(root.right, k, pq);
    }
}