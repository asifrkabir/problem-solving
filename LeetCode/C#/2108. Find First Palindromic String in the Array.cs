public class Solution {
    public string FirstPalindrome(string[] words) {
        var output = "";
        
        foreach(var word in words)
        {
            if(String.Equals(word, new string(word.Reverse().ToArray()))){
                output = word;
                break;
            }
        }
        
        return output;
    }
}