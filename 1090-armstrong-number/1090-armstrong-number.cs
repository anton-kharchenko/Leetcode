public class Solution {
    public bool IsArmstrong(int n) {
        var result = 0;
        var arr = n.ToString().ToCharArray();
        var length = arr.Length;

        for(var i = 0; i<arr.Length; i++){
            var number = int.Parse(arr[i].ToString()); 
            var pow = (int)Math.Pow(number, length);
            result += pow;
        }

        return result == n;
    }
}