public class Solution {
    public string SmallestSubsequence(string s) {
        char[] letters = s.ToCharArray();
        int[] lettersLastIndex = new int[26];
        bool[] usedLetters = new bool[26];
        Stack<char> subsequence = new Stack<char>();

        for(int letterIndex = 0; letterIndex<letters.Length; letterIndex++)
            lettersLastIndex[letters[letterIndex] - 'a'] = letterIndex;

        for(int letterIndex = 0; letterIndex<letters.Length; letterIndex++){
            char letter = letters[letterIndex];
            int letterCode = letter - 'a';

            if(usedLetters[letterCode]) 
                continue;

            while(subsequence.Any()){
                char subsiquenceLastLetter = subsequence.Peek();
                if(subsiquenceLastLetter < letter) 
                    break;

                int subsiquenceLastLetterCode  =   subsiquenceLastLetter - 'a';
                if(lettersLastIndex[subsiquenceLastLetterCode] < letterIndex) 
                    break;

                subsequence.Pop();
                usedLetters[subsiquenceLastLetterCode]  = false;
            }

            subsequence.Push(letter);
            usedLetters[letterCode]  = true;  
        }

        StringBuilder result = new  StringBuilder();

        while(subsequence.Any())
            result.Append(subsequence.Pop());

        return new string(result.ToString().Reverse().ToArray());
    }
}