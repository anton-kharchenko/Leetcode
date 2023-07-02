/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
       if(head == null)
            return null;
        
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();
        
        // Deep copy nodes for values
        Node curr = head;
        while(curr != null)
        {
            dic.Add(curr, new Node(curr.val, null, null));
            curr = curr.next;
        }
        
        // Deep copy nodes for pointers
        curr = head;
        while(curr != null)
        {
            // key of dictionary can't be null
            dic[curr].next = curr.next == null? null : dic[curr.next];
            dic[curr].random = curr.random == null? null : dic[curr.random];
            curr = curr.next;
        }
        
        return dic[head];
    }
}