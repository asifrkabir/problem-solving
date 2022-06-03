public class Solution {
    public int MostWordsFound(string[] sentences) {
        var maxWords = 0;
        
        for(var i = 0; i < sentences.Length; i++){
            var words = sentences[i].Split(' ');
            
            maxWords = words.Length > maxWords ? words.Length : maxWords;
        }
        
        return maxWords;
    }
}