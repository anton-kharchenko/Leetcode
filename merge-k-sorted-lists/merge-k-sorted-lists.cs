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
    public ListNode MergeKLists(ListNode[] lists) {
        var ans = new ListNode();
        var res = ans;
        
        var n = lists.Length;
        var index = 0;
        var list = new List<int>();
        
        while(index < n){
            var curr = lists[index];
            while(curr != null){
                list.Add(curr.val);  
                curr = curr.next;
            }
            index++;
        }
        
        
        list.Sort();
        
        for(var i = 0; i<list.Count;i++){
            res.next = new ListNode(list[i]);
            res = res.next;
        }
        
        
        return ans.next;
    }
}