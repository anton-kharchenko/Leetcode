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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var result = new ListNode[k];
        var length = 0;
        var curr = head;
        ListNode prev = null;
        
        while(curr!= null){
            length++;
            curr = curr.next;
        }
        
        curr = head;
        
        var cof = length / k;
        var extra = length % k;
        
       for(var i = 0;i< k; i++){
           var additional = i<extra? 1: 0;
           var steps = 0;
           result[i] = curr;
           while(curr != null && steps< cof + additional){
               prev = curr;
               curr = curr.next;
               steps++;
           }
           if(prev != null)
               prev.next = null;
       }
        
        
        
        return result;
        
    }
}