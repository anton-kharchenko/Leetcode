public class Solution {
    public int LastStoneWeight(int[] stones) {
        int len = stones.Length;
        if (len == 1)
            return stones[0];

        Array.Sort(stones);
        
        while (stones[len - 2] != 0)
        {
            stones[len - 1] -= stones[len - 2];
            stones[len - 2] = 0;
            Array.Sort(stones);
        }
        
        return stones[len - 1];   
    }
}