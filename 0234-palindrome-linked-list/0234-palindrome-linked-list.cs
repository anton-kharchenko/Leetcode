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
    public bool IsPalindrome(ListNode head)
    {
        if (head.next == null) return true;
        var slow = new Node(head).head;
        var fast = new Node(head).head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var current = new Node(head).head;
        slow = ReverseLinkedList(slow);
        while (slow != null)
        {
            if (current.val != slow.val) return false;
            current = current.next;
            slow = slow.next;
        }

        return true;
    }

    public ListNode ReverseLinkedList(ListNode head)
    {
        ListNode reversed = null;
        var current = head;
        while (current!= null)
        {
            var next = current.next;
            current.next = reversed;
            reversed = current;
            current = next;
        }
        return reversed;
    }
}

public class Node
{
    public ListNode head;

    public Node()
    {
        this.head = null;
    }

    public Node(ListNode head)
    {
        this.head = head;
    }
}