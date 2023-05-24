public class Solution {
    public int Candy(int[] ratings) {
        var length = ratings.Length;
        var leftArray = new int[length];
        var rightArray = new int[length];
        int ans = 0;
        
        Array.Fill(leftArray, 1);
        Array.Fill(rightArray, 1);
        
        for(var i =1; i<length; i++){
            if(ratings[i-1]<ratings[i]){
               leftArray[i]= leftArray[i - 1] +1; 
            }
        }
        
        for(var i = length - 2; i>= 0 ; i--){
            if(ratings[i]>ratings[i+1]){
                rightArray[i] = rightArray[i+1] +1;
            }
        }
        
        for(var i = 0; i<length; i++){
            ans += Math.Max(rightArray[i], leftArray[i]);
        }
        
        return ans;
    }
}