public class Solution {
    public string RestoreString(string s, int[] indices) {
        StringBuilder shuffledString = new StringBuilder();
        shuffledString.Append(s);
        
        for(var i = 0; i < s.Length; i++)
        {
            shuffledString[indices[i]] = s[i];
        }
        
        return shuffledString.ToString();
    }
}