public class Solution {
    public string TruncateSentence(string s, int k) {
        var wordArray = s.Split(" ");
        
        return string.Join(" ", wordArray[0..k]);
    }
}