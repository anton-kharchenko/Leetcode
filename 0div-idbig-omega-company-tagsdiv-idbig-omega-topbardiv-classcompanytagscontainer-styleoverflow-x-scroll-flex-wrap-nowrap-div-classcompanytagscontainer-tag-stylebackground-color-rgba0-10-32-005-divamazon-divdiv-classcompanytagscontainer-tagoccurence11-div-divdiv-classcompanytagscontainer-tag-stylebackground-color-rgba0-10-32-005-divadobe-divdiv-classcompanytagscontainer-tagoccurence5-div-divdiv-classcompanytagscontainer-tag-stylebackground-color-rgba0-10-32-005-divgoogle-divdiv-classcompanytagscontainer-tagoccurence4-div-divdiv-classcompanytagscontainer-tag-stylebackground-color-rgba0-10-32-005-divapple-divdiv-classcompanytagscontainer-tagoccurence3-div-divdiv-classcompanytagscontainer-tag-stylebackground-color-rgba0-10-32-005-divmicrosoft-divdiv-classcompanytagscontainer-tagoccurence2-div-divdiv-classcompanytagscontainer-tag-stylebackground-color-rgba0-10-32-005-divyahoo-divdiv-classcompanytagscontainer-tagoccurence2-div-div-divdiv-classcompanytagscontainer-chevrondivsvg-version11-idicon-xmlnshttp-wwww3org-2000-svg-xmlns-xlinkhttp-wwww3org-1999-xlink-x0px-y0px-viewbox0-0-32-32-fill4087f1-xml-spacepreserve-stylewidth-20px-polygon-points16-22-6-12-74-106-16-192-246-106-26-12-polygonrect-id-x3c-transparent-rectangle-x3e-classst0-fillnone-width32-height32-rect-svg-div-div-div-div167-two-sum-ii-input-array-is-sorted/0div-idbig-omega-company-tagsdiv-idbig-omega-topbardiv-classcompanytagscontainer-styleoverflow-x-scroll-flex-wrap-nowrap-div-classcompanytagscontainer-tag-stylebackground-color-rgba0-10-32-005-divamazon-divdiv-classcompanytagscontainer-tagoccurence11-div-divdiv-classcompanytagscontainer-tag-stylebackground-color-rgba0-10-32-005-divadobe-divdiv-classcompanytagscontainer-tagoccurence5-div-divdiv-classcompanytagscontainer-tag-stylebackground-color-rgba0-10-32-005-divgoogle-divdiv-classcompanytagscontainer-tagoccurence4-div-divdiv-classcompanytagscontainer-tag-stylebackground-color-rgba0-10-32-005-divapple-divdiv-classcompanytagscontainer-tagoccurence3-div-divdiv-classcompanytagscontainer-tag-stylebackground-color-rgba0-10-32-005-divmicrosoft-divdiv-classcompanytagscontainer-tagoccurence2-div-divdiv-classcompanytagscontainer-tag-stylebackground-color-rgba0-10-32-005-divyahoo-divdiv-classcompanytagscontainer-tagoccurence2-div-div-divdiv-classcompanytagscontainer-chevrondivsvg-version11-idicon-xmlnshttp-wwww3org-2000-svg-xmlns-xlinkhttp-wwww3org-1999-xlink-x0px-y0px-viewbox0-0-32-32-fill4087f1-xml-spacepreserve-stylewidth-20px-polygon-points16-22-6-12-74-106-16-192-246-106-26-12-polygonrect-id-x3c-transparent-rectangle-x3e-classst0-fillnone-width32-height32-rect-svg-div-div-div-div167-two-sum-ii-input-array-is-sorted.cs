public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var res = new int[2];
        var left = 0;
        var right = numbers.Length - 1;
        
        while(left < right){
            
            if(target == numbers[right] + numbers[left]){
                res[0] = left+1;
                res[1] = right +1;
                return res;
            }else if(target < numbers[right] + numbers[left]){
                right--;
            }else{
                left ++;
            }
        }
        
        return res;
    }
}