public class Solution {
public string IntToRoman(int n) => n switch
{
    >= 1000 => $"M{IntToRoman(n - 1000)}",
    >= 900 => $"CM{IntToRoman(n - 900)}",
    >= 500 => $"D{IntToRoman(n - 500)}",
    >= 400 => $"CD{IntToRoman(n - 400)}",
    >= 100 => $"C{IntToRoman(n - 100)}",
    >= 90 => $"XC{IntToRoman(n - 90)}",
    >= 50 => $"L{IntToRoman(n - 50)}",
    >= 40 => $"XL{IntToRoman(n - 40)}",
    >= 10 => $"X{IntToRoman(n - 10)}",
    >= 9 => $"IX{IntToRoman(n - 9)}",
    >= 5 => $"V{IntToRoman(n - 5)}",
    >= 4 => $"IV{IntToRoman(n - 4)}",
    >= 1 => $"I{IntToRoman(n - 1)}",
    >= 0 => ""
};
        
    
}