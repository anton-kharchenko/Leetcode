public class Solution {
    public int TotalMoney(int n) {
        int cof = 1;
        int totalMoney = 0;
        int money = 1;
        
        for(int i = 1; i<=n; i++ ){
            if(i/7>0 && i%7==1 ){
                cof += 1;
                money = cof;
            }
            
            totalMoney += money;
            money += 1;
        }
        
        return totalMoney;
    }
}