public class Solution {
    public bool DivisorGame(int n) {
        return AliceWon(n, true);
    }

    public bool AliceWon(int n, bool isAliceTurn){
        if((n % 2 == 1 && isAliceTurn) || (n % 2 == 0 && !isAliceTurn) ){
            return false;
        }

        if((n % 2 == 0 && isAliceTurn) || (n % 2 == 1 && !isAliceTurn)){
            return true;
        }

        return AliceWon(n - 1, !isAliceTurn) && AliceWon(n - 2, !isAliceTurn);
    }
}