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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        var result = new int[2];
        ListNode prev = null;
        ListNode next = head.next;
        ListNode curr = head;
        var criticalPoints = new List<int>();
        var index = 1;
        while(next != null){
            if(prev != null){
                if((prev.val < curr.val && curr.val>next.val) || (prev.val > curr.val && curr.val<next.val)){
                    criticalPoints.Add(index);
                }
            }
            prev = curr;
            curr = curr.next;
            next = curr.next;
            index += 1;
        }

        var min = int.MaxValue;
        
        for(var i = 0; i<criticalPoints.Count - 1; i++)
        {
            min = Math.Min(Math.Abs(criticalPoints[i + 1] - criticalPoints[i]), min);
        }

        result[0] = min == int.MaxValue ? -1 : min;
        result[1] = criticalPoints.Count < 2?  -1 : criticalPoints[^1] - criticalPoints[0];

        return result;
    }
}