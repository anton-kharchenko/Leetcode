/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    public TreeNode SortedListToBST(ListNode head) {
        int nodesCount = 0;
        var current = head;
        List<int> list = new List<int>();
        while(current != null){
            nodesCount += 1;
            list.Add(current.val);
            current = current.next;
        }

        return BuildTree(0, nodesCount - 1, list);
    }

    private TreeNode BuildTree(int start, int end,  List<int> list)
    {
        if (start>end)
        {
            return null;
        }

        var mid = (start + end) / 2;

        var node = new TreeNode(list[mid]);
        node.left = BuildTree(start, mid - 1, list);
        node.right = BuildTree(mid + 1, end,  list);
        
        return node;
    }


}