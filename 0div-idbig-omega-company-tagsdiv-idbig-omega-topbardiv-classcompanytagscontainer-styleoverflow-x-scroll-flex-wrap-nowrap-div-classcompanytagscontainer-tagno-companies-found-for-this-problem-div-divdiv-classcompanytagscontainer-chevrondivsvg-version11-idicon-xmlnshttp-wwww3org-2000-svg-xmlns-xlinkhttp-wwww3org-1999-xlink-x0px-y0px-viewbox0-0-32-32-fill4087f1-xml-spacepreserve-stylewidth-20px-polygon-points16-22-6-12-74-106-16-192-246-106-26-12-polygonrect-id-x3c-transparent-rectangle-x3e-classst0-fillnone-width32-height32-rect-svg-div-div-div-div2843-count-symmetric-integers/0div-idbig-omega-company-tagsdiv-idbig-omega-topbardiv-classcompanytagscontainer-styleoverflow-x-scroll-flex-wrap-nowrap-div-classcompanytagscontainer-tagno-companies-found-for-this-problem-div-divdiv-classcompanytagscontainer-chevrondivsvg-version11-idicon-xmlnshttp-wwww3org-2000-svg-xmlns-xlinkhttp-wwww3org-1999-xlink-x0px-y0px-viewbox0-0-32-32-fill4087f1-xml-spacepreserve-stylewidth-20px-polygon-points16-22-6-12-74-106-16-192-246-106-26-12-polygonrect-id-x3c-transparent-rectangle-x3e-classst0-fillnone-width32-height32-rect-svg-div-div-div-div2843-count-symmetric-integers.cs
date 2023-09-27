public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int res = 0;
        for(var i = low; i<= high; i++){
            if(i.ToString().Length % 2 == 0){
                if(IsSymmetric(i.ToString())){
               res++; 
            }
            }
        }
        
        return res;
    }
    
    public bool IsSymmetric(string number){
        var low = 0;
        var high = number.Length - 1;
        var firstNumber = 0;
        var secondNumber  = 0;
        
        while(low<high){
            firstNumber += int.Parse(number[low].ToString());
            secondNumber += int.Parse(number[high].ToString());
            low++;
            high--;
        }
        
        if(firstNumber == secondNumber) 
            return true;
        
        return false;
    }  
}