public class Solution {
    public bool WinnerOfGame(string colors) {
            int aliceCount = 0;
            int bobCount = 0;
        
            for(var i = 1; i<colors.Length - 1; i++){
                if(colors[i - 1] == colors[i] && colors[i] == colors[i+1]){
                    if(colors[i] == 'A'){
                        aliceCount++;
                    }else{
                        bobCount++;
                    }
                }

            }
        
            return aliceCount > bobCount;
    }

}