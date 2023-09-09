public class Solution {
    public string ReverseOnlyLetters(string s) {
        var left = 0;
        var right = s.Length - 1;
        var arr = s.ToCharArray();
        while(left<= right){
            if(char.IsLetter(arr[left]) && char.IsLetter(arr[right])){
                (arr[left], arr[right])=(arr[right], arr[left]);
                left++;
                right--;
            }else if (!char.IsLetter(arr[left])){
                 left++;
            }else if(!char.IsLetter(arr[right])){
                 right--;
            }
            
        }
        
        return string.Concat(arr);
    }
}