public class Solution {
    public int TotalMoney(int n) {
        int coefficient = 1;
        int money = 1;
        int totalMoney = 0;
        for (int i = 1; i <=n; i++)
        {
            if(i / 7 > 0 &&  i % 7 == 1){
                coefficient += 1;
                money = coefficient;
            }
            totalMoney += money;
            money += 1;
        }
        return  totalMoney; 
    }
}