public class Solution {
    public string ReversePrefix(string word, char ch) {
        if(!word.Contains(ch)) return word;
        
        var indexOfChar = word.IndexOf(ch);
        
        return new string(word[0..(indexOfChar + 1)].Reverse().ToArray()) + word[(indexOfChar + 1)..(word.Length)];
    }
}