public class Solution {
    public IList<string> CommonChars(string[] words) {
        var output = new List<string>();
        var wordDict = new Dictionary<char, int>();
        var n = words.Length;
        
        for(var i = 0; i < n; i++)
        {
            if(i == 0)
            {
                foreach(var letter in words[i])
                {
                    if(!wordDict.ContainsKey(letter))
                    {
                        wordDict.Add(letter, 1);
                    }
                    else
                    {
                        wordDict[letter]++;
                    }
                }
            }
            else
            {
                var newWordDict = new Dictionary<char, int>();
                
                foreach(var letter in words[i])
                {
                    if(!newWordDict.ContainsKey(letter))
                    {
                        newWordDict.Add(letter, 1);
                    }
                    else
                    {
                        newWordDict[letter]++;
                    }
                }
                
                foreach(var entry in wordDict)
                {
                    if(!newWordDict.ContainsKey(entry.Key))
                    {
                        wordDict.Remove(entry.Key);
                    }
                    else
                    {
                        wordDict[entry.Key] = Math.Min(entry.Value, newWordDict[entry.Key]);
                    }
                }
            }
        }
        
        foreach(var entry in wordDict)
        {
            var stringToAdd = entry.Key.ToString();
            
            for(var i = 0; i < entry.Value; i++)
            {
                output.Add(stringToAdd);
            }    
        }
        
        return output;
    }
}