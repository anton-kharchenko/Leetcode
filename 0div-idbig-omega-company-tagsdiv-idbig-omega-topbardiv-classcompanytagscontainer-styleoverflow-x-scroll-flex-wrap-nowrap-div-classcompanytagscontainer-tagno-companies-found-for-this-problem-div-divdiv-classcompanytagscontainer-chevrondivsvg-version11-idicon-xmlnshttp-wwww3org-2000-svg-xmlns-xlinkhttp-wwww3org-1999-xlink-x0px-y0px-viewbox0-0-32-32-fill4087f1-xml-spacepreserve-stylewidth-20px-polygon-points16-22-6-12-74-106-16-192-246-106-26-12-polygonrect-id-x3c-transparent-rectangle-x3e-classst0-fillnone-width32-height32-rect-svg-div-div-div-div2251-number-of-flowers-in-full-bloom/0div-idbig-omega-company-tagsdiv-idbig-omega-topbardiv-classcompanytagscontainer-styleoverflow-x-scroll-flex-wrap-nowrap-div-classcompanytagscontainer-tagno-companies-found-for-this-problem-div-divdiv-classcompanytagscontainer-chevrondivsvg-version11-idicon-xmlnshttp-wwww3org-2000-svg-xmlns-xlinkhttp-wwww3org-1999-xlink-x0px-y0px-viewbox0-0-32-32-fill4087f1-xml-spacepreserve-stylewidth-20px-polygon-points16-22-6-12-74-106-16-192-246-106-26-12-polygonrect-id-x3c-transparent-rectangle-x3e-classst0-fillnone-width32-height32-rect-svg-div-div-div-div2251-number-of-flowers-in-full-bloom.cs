public class Solution {
    public int[] FullBloomFlowers(int[][] flowers, int[] people) {
        List<int> starts = new List<int>();
        List<int> ends = new List<int>();
        
        foreach (int[] flower in flowers) {
            starts.Add(flower[0]);
            ends.Add(flower[1] + 1);
        }
        
        starts.Sort();
        ends.Sort();
        int[] ans = new int[people.Length];
        
        for (int index = 0; index < people.Length; ++index) {
            int person = people[index];
            int i = BinarySearch(starts, person);
            int j = BinarySearch(ends, person);
            ans[index] = i - j;
        }
        
        return ans;
    }
    
    public int BinarySearch(List<int> arr, int target) {
        int left = 0;
        int right = arr.Count;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (target < arr[mid]) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
}