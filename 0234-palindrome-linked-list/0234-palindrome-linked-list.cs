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
public class Solution {
    public bool IsPalindrome(ListNode head) {
        
        Stack<int> stack = new Stack<int>();
        ListNode slow = head;
        ListNode fast = head;
        
        while (fast != null && fast.next != null) {
            stack.Push(slow.val);
            slow = slow.next;
            fast = fast.next.next;
        }
        
        if (fast != null) { // odd length list
            slow = slow.next;
        }
        
        while (slow != null) {
            if (slow.val != stack.Pop()) {
                return false;
            }
            slow = slow.next;
        }
        
        return true;
        
    }
}