public class MinStack {
    Stack<int> minStack;
    Stack<int> stack;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        if (minStack.Count == 0)
        {
            minStack.Push(val);
        }
        else
        {
            if (minStack.Peek() >= val)
            {
                minStack.Push(val);
            }
        }
        stack.Push(val);
    }
    
    public void Pop()
    {
        if (stack.Count > 0)
        {
            var top = stack.Pop();
            if (top == minStack.Peek())
            {
                minStack.Pop();
            }
        }
    }
    
    public int Top()
    {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */