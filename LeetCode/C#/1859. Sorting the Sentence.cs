public class Solution {
    public string SortSentence(string s) {
        String[] words = s.Split(' ');
        var sentence = new String[words.Length];
        
        for(var i = 0; i < words.Length; i++)
        {
            var index = int.Parse((words[i][words[i].Length - 1]).ToString()) - 1;
            var currentWord = words[i].Remove(words[i].Length - 1);
            sentence[index] = currentWord;
        }
        
        return string.Join(" ", sentence);
    }
}