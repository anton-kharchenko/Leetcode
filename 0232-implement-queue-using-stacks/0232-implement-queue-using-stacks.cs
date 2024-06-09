public class MyQueue {
    Stack<int> stack;
    public MyQueue() {
        stack = new Stack<int>();
    }
    
    public void Push(int x) {
        
        if(stack.Count == 0){
            stack.Push(x);
        }else
        {
            var dummy = new Stack<int>();
            var queueSize = stack.Count;
            for (int i = 0; i < queueSize; i++)
                dummy.Push(stack.Pop());
            dummy.Push(x);

            var len = dummy.Count;
            for (int i = 0; i < len; i++)
                stack.Push(dummy.Pop());
        }
    }
    
    public int Pop() {

        return stack.Pop();
    }
    
    public int Peek() {
        return stack.Peek();
    }
    
    public bool Empty() {
        return stack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */