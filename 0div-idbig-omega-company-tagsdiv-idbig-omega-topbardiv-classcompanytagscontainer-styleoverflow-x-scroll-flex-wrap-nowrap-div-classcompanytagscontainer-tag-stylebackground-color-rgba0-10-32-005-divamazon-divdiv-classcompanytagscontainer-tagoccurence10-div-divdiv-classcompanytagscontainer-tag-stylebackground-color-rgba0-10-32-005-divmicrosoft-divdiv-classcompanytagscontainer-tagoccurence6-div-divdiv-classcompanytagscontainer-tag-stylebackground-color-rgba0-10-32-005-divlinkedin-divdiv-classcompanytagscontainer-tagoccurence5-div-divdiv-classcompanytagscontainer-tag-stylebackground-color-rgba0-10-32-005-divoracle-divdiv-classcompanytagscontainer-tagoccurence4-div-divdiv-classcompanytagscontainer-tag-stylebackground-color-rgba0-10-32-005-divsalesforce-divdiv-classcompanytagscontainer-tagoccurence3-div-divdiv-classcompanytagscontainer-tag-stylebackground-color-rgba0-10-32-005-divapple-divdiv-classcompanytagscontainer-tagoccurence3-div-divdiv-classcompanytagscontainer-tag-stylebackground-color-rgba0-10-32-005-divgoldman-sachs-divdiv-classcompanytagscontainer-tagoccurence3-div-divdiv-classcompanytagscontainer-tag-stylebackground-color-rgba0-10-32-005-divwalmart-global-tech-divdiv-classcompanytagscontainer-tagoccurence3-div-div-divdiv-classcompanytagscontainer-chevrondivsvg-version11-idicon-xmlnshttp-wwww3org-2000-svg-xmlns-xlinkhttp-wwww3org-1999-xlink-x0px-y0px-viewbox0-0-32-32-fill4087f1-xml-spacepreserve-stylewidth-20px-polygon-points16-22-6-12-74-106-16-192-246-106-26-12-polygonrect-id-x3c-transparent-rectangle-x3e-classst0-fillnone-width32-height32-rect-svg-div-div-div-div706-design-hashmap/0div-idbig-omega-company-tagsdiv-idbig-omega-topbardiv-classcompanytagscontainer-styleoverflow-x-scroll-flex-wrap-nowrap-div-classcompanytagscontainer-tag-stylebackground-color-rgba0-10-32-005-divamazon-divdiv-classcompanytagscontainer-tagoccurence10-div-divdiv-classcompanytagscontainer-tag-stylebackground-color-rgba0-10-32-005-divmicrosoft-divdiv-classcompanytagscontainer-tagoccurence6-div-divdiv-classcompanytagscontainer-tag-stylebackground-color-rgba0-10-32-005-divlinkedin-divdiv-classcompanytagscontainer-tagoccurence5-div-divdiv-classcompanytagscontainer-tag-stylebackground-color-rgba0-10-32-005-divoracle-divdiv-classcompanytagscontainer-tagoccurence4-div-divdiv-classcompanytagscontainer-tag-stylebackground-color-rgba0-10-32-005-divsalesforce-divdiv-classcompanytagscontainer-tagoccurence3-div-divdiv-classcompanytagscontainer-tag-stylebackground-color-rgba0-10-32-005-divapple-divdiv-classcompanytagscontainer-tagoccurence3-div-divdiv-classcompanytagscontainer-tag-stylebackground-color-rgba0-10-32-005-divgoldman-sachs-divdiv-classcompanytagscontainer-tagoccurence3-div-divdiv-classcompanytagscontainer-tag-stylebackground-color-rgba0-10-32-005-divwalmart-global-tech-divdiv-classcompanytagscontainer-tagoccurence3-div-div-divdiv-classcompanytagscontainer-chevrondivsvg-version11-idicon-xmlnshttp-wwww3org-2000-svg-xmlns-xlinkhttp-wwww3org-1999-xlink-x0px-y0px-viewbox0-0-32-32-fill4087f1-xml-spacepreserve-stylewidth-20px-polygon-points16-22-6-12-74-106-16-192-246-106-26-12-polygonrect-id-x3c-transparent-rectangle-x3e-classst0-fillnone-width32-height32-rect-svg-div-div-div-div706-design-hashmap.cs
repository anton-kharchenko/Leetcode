public class MyHashMap {
    int[] arr;
    public MyHashMap() {
        arr = new int[1000001];
        Array.Fill(arr, int.MinValue);
    }
    
    public void Put(int key, int value) {
        arr[key] = value;
    }
    
    public int Get(int key) {
        if(arr[key] != int.MinValue)
            return arr[key];
        return -1;   
    }
    
    public void Remove(int key) {
        arr[key] = int.MinValue;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */