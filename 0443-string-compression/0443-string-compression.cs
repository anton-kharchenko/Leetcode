public class Solution {
    public int Compress(char[] chars) {
        int i = 0, res = 0;

        while(i < chars.Length) {
            int groupLength = 1;

            while(i + groupLength < chars.Length && chars[i + groupLength] == chars[i])
                groupLength += 1;

            chars[res++] = chars[i];

            if(groupLength > 1) {
                foreach(var v in groupLength.ToString())
                    chars[res++] = v;
            }
            
            i += groupLength;
        }
        
        return res;
    }
}