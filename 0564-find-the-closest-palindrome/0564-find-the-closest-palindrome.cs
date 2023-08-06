public class Solution
{
    public string NearestPalindromic(string n)
    {
        int length = n.Length;
        int left = (length + 1) / 2, right = length - left;
        long head = long.Parse(n.Substring(0, left));
        long origin = long.Parse(n);
        long diff = long.MaxValue;
        long num = 0;
        
        for(var i = -1; i<= 1; i++ ){
            var ret = GetPalindrom(head + i, right);
            if(ret != origin && Math.Abs(ret - origin)<diff){
                diff = Math.Abs(ret - origin);
                num = ret;
            }
        }
        
        return num.ToString();
    }
    
    public long GetPalindrom(long head, int rightLength){
        var str = head.ToString();
        var sb = new StringBuilder(str);
        
        
        if(head == 0 || rightLength> str.Length){
            for(var i = 0; i<rightLength; i++)
                sb.Append('9');
        }else{
            for (int i = rightLength - 1; i >= 0; i--)
                sb.Append(str[i]);
        }
        
        return long.Parse(sb.ToString());
    }
}