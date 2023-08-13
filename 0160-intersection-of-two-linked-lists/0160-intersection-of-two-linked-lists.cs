/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var l1 = headA;
        var l2 = headB;

        while(l1!=l2){
            l1 = l1 == null? headA :  l1.next;
            l2 = l2 == null? headB :  l2.next;
        }

        return l2;

    }
}