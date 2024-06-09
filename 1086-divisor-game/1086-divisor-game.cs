public class Solution {
    public bool DivisorGame(int n) {
        return AliceWon(n, true, new int[n + 1]);
    }

    public bool AliceWon(int n, bool isAliceTurn, int[] cache){
        if(cache[n] != 0){
            return cache[n] == 1 ? true : false;
        }

        if((n % 2 == 1 && isAliceTurn) || (n % 2 == 0 && !isAliceTurn) ){
            return false;
        }

        if((n % 2 == 0 && isAliceTurn) || (n % 2 == 1 && !isAliceTurn)){
            return true;
        }

        var res = AliceWon(n - 1, !isAliceTurn, cache) && AliceWon(n - 2, !isAliceTurn, cache);
        if(res == true){
            cache[n] = 1;
        }else{
            cache[n] = -1;
        }
        return res;
    }
}