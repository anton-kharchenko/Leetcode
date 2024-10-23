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
        var minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        FillHeap(minHeap, root, k);
        return minHeap.Peek();
    }

    private void FillHeap(PriorityQueue<int, int> minHeap, TreeNode root, int i)
    {
        if(root == null) return;
        minHeap.Enqueue(root.val, root.val);
        if(i < minHeap.Count) minHeap.Dequeue();
        FillHeap(minHeap, root.left, i);
        FillHeap(minHeap, root.right, i);
    }
}

