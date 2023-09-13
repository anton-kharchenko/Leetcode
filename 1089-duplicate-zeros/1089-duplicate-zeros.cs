public class Solution {
    public void DuplicateZeros(int[] arr) {
        var list = new List<int>();
        
        for(var i = 0; i<arr.Length; i++){
            if(arr[i] == 0){
                list.Add(0);
                list.Add(0);
            }else{
                list.Add(arr[i]);
            }
        }
        
        Array.Copy(list.ToArray(), arr, arr.Length);
    }
}