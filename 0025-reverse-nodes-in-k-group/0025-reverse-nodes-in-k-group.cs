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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0, head);
        var prevGroup = dummy;
        
        while(true){
            var kth = GetNode(prevGroup, k);
            
            if(kth==null){
                break;
            }
            var groupNext = kth.next;
            
            // reverse group
            var prev = kth.next;
            var curr = prevGroup.next;
            
            while(curr != groupNext){
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            
            var tmp = prevGroup.next;
            prevGroup.next = kth;
            prevGroup = tmp;
            
        }
        
        return dummy.next;
    }
    
    public ListNode GetNode(ListNode node, int k){
        var curr = node;
        while(k>0 && curr!=null){
            k--;
            curr = curr.next;
        }
        
        return curr;
    }
}