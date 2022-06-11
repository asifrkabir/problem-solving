public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        return (string.Equals(string.Join("", word1), string.Join("", word2)));
    }
}