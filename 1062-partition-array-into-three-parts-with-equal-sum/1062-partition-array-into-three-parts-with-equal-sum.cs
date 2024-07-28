public class Solution {
    public bool CanThreePartsEqualSum(int[] arr)
    {
        if (arr.Sum() % 3 != 0) return false;
        int sum = 0, count = 0, target = arr.Sum() / 3;
        foreach (var number in arr)
        {
            sum += number;
            if (sum == target)
            {
                sum = 0;
                count++;
            }
        }
        return count >= 3;
    }
}