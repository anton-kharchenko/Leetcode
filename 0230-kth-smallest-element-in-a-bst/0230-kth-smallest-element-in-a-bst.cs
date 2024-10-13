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
        DFS(root, pq, k);
        return pq.Peek();
    }

    public void DFS(TreeNode node, PriorityQueue<int, int> pq, int k)
    {
        if (node is null)
        {
            return;
        }

        pq.Enqueue(node.val, node.val);
        if (pq.Count > k)
        {
            pq.Dequeue();
        }
        DFS(node.left, pq, k);
        DFS(node.right, pq, k);
    }
}