public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        var count = 0;
        
        var wordDict1 = new Dictionary<string, int>();
        var wordDict2 = new Dictionary<string, int>();
        var uniqueWords = new Dictionary<string, int>();
        
        for(var i = 0; i < words1.Length; i++)
        {
            if(!wordDict1.ContainsKey(words1[i]))
            {
                wordDict1.Add(words1[i], 1);
            }
            else
            {
                wordDict1[words1[i]]++;
            }
        }
        
        for(var i = 0; i < words2.Length; i++)
        {
            if(!wordDict2.ContainsKey(words2[i]))
            {
                wordDict2.Add(words2[i], 1);
            }
            else
            {
                wordDict2[words2[i]]++;
            }
        }
        
        foreach(var entry in wordDict1)
        {
            if(entry.Value == 1)
            {
                uniqueWords.Add(entry.Key, 1);
            }
        }
        
        foreach(var entry in wordDict2)
        {
            if(entry.Value == 1)
            {
                if(!uniqueWords.ContainsKey(entry.Key))
                {
                    uniqueWords.Add(entry.Key, 1);
                }
                else
                {
                    uniqueWords[entry.Key]++;
                    count++;
                }
            }
        }
        
        return count;
    }
}