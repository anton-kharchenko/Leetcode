public class CustomStack {
    int[] _stack;
    int _size;
    int _top;

    public CustomStack(int maxSize) {
        _size = maxSize;
        _stack = new int[maxSize];
        _top = -1;
    }
    
    public void Push(int x)
    {
        var next = _top + 1;
        if (next <= _size - 1)
        {
            _stack[next] = x;
            _top += 1;
        }
    }
    
    public int Pop() {
        if(_top == -1) return -1;
        return _stack[_top--]; 
    }
    
    public void Increment(int k, int val) {
        var inc = Math.Min(k, _size);
        for(var i = 0; i < inc; i++)
            _stack[i] += val;
    }
}