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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        var res = new ListNode();
        var ans = res;
        var curr = head;
        
        ans.next = new ListNode(curr.val);
        ans = ans.next;
        
        while(curr != null && curr.next!= null){
            
            var start = curr.val;
            var end = curr.next.val;
            var mid = FindGreatesCommonDivisor(start, end);

            ans.next = new ListNode(mid);
            ans = ans.next;
            
            ans.next = new ListNode(end);
            ans = ans.next;
            
            curr = curr.next;
        }
        
        return res.next;
    }
    
    public int FindGreatesCommonDivisor(int firstNumber, int secondNumber){
      return secondNumber == 0 ? firstNumber: FindGreatesCommonDivisor(secondNumber, firstNumber%secondNumber);
    }
}