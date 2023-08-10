public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var ret = new int[nums.Length - k + 1];

        var indexList = new List<int>();

        for (var index = 0; index < nums.Length; index++)
        {
            while (indexList.Count > 0 &&
                   nums[indexList.Last()] < nums[index]) // If not empty and nums from last index less then current
                indexList.RemoveAt(indexList.Count - 1); // Delete last index 

            indexList.Add(index);

            if (index - k >= indexList[0])
                indexList.RemoveAt(0);

            if (index - k + 1 >= 0)
                ret[index - k + 1] = nums[indexList[0]];
        }

        return ret;
    }
}