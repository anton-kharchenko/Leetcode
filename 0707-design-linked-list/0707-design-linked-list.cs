public class MyLinkedList {
    private Node head;
    private int count;

    public MyLinkedList() {
        this.head = null;
        this.count = 0;
    }
    
    public Node GetNode(int index) {
        if(index >= count)
            return null;
        
        Node refHead = head;
        
        for(int i = 0; i < index; i++)
            refHead = refHead.next;
        
        return refHead;
    }
    
    public int Get(int index) {
        Node ans = GetNode(index);
        return ans == null ? -1 : ans.val;
    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val, head);
        head = newNode;
        count++;
    }
    
    public void AddAtTail(int val) {
        if(head == null) {
            AddAtHead(val);
            return;
        }
        else {
            Node node = GetNode(count - 1);
            node.next = new Node(val, null);
            count++;
        }
    }
    
    public void AddAtIndex(int index, int val) {
        if(index > count)
            return;
        
        if(index == 0) {
            AddAtHead(val);
            return;
        }
        else if(index == count) {
            AddAtTail(val);
            return;
        }
        else 
        {
            Node current = GetNode(index);
            Node before = GetNode(index - 1);

            Node newNode = new Node(val, current);
            before.next = newNode;
            count++;
        }
        
    }
    
    public void DeleteAtIndex(int index) 
    {
        if(count == 0)
            return;
        
        if(index < count && index >= 0)
        {
            if(index == 0)
                head = head.next;
            else
            {
                var node = GetNode(index - 1);
                node.next = node.next.next;
            }
            
            count--;
        }
    }
}

public class Node{
    public int val;
    public Node next;
 
    public Node(int val, Node next){
        this.val =  val;
        this.next = next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */