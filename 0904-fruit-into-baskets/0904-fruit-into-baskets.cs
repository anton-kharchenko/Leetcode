public class Solution {
    public int TotalFruit(int[] fruits) {
        int totalFruit = 0;
        Dictionary<int, int> frequency = new  Dictionary<int, int>();
        int currentFruitCount = 0;
        int leftPointer = 0;
        
        foreach(int fruit in fruits){
            if(frequency.ContainsKey(fruit)){
                frequency[fruit] += 1;
            }else{
                frequency.Add(fruit, 1);
            }
            currentFruitCount += 1;
            
            if(frequency.Count>2){
                int fruitToDelete = fruits[leftPointer];
                frequency[fruitToDelete] -= 1;
                currentFruitCount -= 1;
                leftPointer += 1;
                if(frequency[fruitToDelete] == 0){
                    frequency.Remove(fruitToDelete);
                }
            }
            
            totalFruit = Math.Max(totalFruit, currentFruitCount);
        }
        
        return totalFruit;
    }
}