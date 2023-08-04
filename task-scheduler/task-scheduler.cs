public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if (n == 0) return tasks.Length;

        var alphabet = new int[26];
        foreach (var task in tasks)
            alphabet[task - 'A']++;

        // Firstly, we found the most repeated element's count, so frequency. 
        // It's the most important part.
        // Because it defines the total length. 
        var maxFrequency = alphabet.Prepend(0).Max();

        var maxFrequencyCount = alphabet.Count(freq => freq == maxFrequency);

        /*
            We start with writing the first element, which is repeated the most.
            That's why we subtract 1 from maxFrequency variable.
            This will give us the count of remaining repeated elements. 
            We multiply this difference with n + 1 (because distance has to be n among each repeated element). 
            And we will add maxFrequencyCount.
        */

        var res = (maxFrequency - 1) * (n + 1) + maxFrequencyCount;

        return Math.Max(tasks.Length, res);
    }
}