public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        var count = 0;
        
        for(var i = 0; i < patterns.Length; i++)
        {
            if(word.Contains(patterns[i])) count++;
        }
        
        return count;
    }
}