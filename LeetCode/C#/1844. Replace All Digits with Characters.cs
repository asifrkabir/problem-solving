public class Solution {
    public string ReplaceDigits(string s) {
        var output = "";
        
        for(var i = 1; i < s.Length; i += 2)
        {
            output += s[i - 1];
            output += Shift(s[i - 1], (int)(s[i] - '0'));
        }
        
        if(s.Length % 2 == 1)
        {
            output += Char.ToString(s[s.Length - 1]);
        }
        
        return output;
    }
    
    public string Shift(char c, int x) {
        return Char.ToString((char)((int)c + x));
    }
}