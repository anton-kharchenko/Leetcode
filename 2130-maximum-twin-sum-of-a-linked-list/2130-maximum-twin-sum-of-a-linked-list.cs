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
    public int PairSum(ListNode head) {
        var slow = head;
        var fast = head;
        var res = 0;
        ListNode prev = null;
        
        while(fast != null && fast.next != null){
            fast = fast.next.next;
            var temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }
        
        while(slow != null){
            res = Math.Max(res, slow.val+prev.val);
            slow = slow.next;
            prev = prev.next;
        }
        
        return res;
    }
}