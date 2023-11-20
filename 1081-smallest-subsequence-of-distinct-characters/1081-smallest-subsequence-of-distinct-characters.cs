public class Solution {
    public string SmallestSubsequence(string s) {
        char[] letters = s.ToCharArray();
        bool[] visited = new bool[26];
        int[] lastLettersIndex = new int[26];
        Stack<char> subsequence = new  Stack<char>();
        StringBuilder result = new StringBuilder();

        for(int letterIndex = 0; letterIndex<s.Length; letterIndex++)
            lastLettersIndex[letters[letterIndex] - 'a'] = letterIndex;

        for(int letterIndex = 0; letterIndex<s.Length; letterIndex++){
            char letter = letters[letterIndex];
            int letterCode = letter - 'a';

            if(visited[letterCode])
                continue;

            while(subsequence.Any()){
                char lastLetter =  subsequence.Peek();
                if(lastLetter<letter)
                    break;

                int lastLetterCode = lastLetter - 'a';
                if(lastLettersIndex[lastLetterCode] < letterIndex)
                    break;

                 visited[lastLetterCode] = false;
                 subsequence.Pop();
            }
           
            visited[letterCode] = true;    
            subsequence.Push(letter);
        }

        while(subsequence.Any())
            result.Append(subsequence.Pop());

        return new string(result.ToString().Reverse().ToArray());    
    }
}