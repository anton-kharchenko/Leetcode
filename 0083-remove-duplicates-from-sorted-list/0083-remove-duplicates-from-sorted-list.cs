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
    public ListNode DeleteDuplicates(ListNode head) {
        var res = new ListNode();
        var ans = res;
        var list = new List<int>();
        var curr = head;
        
        while(curr!=null){
            if(!list.Contains(curr.val)){
                list.Add(curr.val);
            }
            curr = curr.next;
        }
        
        var count = 0;
        
        while(count<list.Count){
            ans.next = new ListNode(list[count]);
            ans = ans.next;
            count++;
        }
        
        return res.next;
    }
}