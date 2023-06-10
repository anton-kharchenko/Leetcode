public class MinStack {
    List<int> st;
    List<int> min;
    public MinStack() {
        st = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int val) {
        st.Add(val);
        min.Add(Math.Min(val, min.Count > 0 ? min[min.Count-1] : val));
    }
    
    public void Pop() {
        st.RemoveAt(st.Count - 1);
        min.RemoveAt(min.Count - 1);
    }
    
    public int Top() {
        return st[st.Count - 1];
    }
    
    public int GetMin() {
        return st.Min();
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