public class Solution
{
    public int LongestSubarray(int[] nums, int limit)
    {
        var startIndex = 0;
        var endIndex = 0;
        var minPQ = new PriorityQueue<(int, int), int>();
        var maxPQ = new PriorityQueue<(int, int), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        var maxLength = 0;

        while (endIndex < nums.Length)
        {
            var number = nums[endIndex];
            
            minPQ.Enqueue((endIndex, number), number);
            maxPQ.Enqueue((endIndex, number), number);

            while (Math.Abs(maxPQ.Peek().Item2 - minPQ.Peek().Item2) > limit)
            {
                startIndex = Math.Min(maxPQ.Peek().Item1, minPQ.Peek().Item1) + 1;
                
                while (startIndex > maxPQ.Peek().Item1)
                {
                    maxPQ.Dequeue();
                }

                while (startIndex > minPQ.Peek().Item1)
                {
                    minPQ.Dequeue();
                }
            }

            maxLength = Math.Max(maxLength, endIndex - startIndex + 1);
            endIndex += 1;
        }

        return maxLength;
    }
}