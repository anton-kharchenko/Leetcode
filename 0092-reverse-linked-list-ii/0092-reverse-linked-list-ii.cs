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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left == right) return head;
        var dummy = new ListNode(-1, head);
        var counter = 0;
        var temp = dummy;
        
        while(counter< left - 1){
            temp = temp.next;
            counter++;
        }
        
        var stack = new Stack<ListNode>();
        
        var t = temp.next;
        
        while(counter<right){
            stack.Push(t);
            t = t.next;
            counter++;
        }
        
        while(stack.Count>0){
            temp.next = stack.Pop();
            temp = temp.next;
        }
        
        temp.next = t;
        
        return dummy.next;
    }
}