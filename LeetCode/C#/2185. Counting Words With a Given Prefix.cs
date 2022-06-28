public class Solution {
    public int PrefixCount(string[] words, string pref) {
        var count = 0;
        
        foreach(var word in words)
        {
            if(word.StartsWith(pref)) count++;
        }
        
        return count;
    }
}