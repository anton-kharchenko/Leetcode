public class Solution {
    public Node Connect(Node root) {
        if(root is null) return null;
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        var stack = new Stack<Node>();
        while(queue.Count>0){
            var size = queue.Count;
            for(var i = 0; i<size; i++){
                var currentNode = queue.Dequeue();
                if(currentNode.left != null) queue.Enqueue(currentNode.left);
                if(currentNode.right != null) queue.Enqueue(currentNode.right);
                stack.Push(currentNode);
            }

            Node prev = null;
            while(stack.Count>0){
                var curr = stack.Pop();
                curr.next = prev;
                prev = curr;
            }
        }
        
        return root;
    }
}