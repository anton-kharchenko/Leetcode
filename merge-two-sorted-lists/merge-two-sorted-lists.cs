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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var merged = new ListNode();
        var res = merged;
        
        while(list1 != null && list2 != null){
            if(list1.val<list2.val){
                merged.next = new ListNode(list1.val);
                list1 = list1.next;
            }else{
                merged.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            merged = merged.next;
        }
        
        while(list1 != null){
            merged.next = new ListNode(list1.val);
            list1 = list1.next;
            merged = merged.next;
        }
        
        while(list2 != null){
            merged.next = new ListNode(list2.val);
            list2 = list2.next;
            merged = merged.next;
        }
        
        return res.next;
    }
}