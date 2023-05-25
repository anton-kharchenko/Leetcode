public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for(var i = 0; i <image.Length; i++){
            image[i] =  FlipArray(image[i], 0, image[i].Length - 1);
            image[i] = InvertArr(image[i]);
        }
        
        return image;
    }
    
    public int[] FlipArray(int[] arr, int start, int end){
        
        while(start<=end){
            (arr[start], arr[end]) = (arr[end], arr[start]);
            start++;
            end--;
        }
        
        return arr;
    }
    
    public int[] InvertArr(int[] arr){
        for(var i =0; i<arr.Length; i++){
            if(arr[i] == 1){
                arr[i] = 0;
            }else{
                arr[i] = 1;
            }
        }
        
        return arr;
    }
}