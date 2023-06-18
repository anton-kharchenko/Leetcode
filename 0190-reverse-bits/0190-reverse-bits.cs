public class Solution {
    public uint reverseBits(uint n) {
        var binary = Convert.ToString(n, 2).PadLeft(32, '0');
        var arr = binary.ToCharArray();
        Array.Reverse(arr);
        var bitString = new string(arr);
        return Convert.ToUInt32(bitString, 2);
    }
}