public class Solution {
    public int CountCharacters(string[] words, string chars) {
        var charTable = new Dictionary<char, int>();
        var sum = 0;
        
        foreach(var c in chars)
        {
            if(!charTable.ContainsKey(c))
            {
                charTable.Add(c, 1);
            }
            else
            {
                charTable[c]++;
            }
        }
        
        foreach(var word in words)
        {
            var wordTable = new Dictionary<char, int>();
            var wordFound = true;
            var l = 0;
            
            foreach(var c in word)
            {
                if(!charTable.ContainsKey(c))
                {
                    wordFound = false;
                    break;
                }
                else
                {
                    if(!wordTable.ContainsKey(c))
                    {
                        wordTable.Add(c, 1);
                    }
                    else
                    {
                        wordTable[c]++;
                    }
                    
                    l++;
                }
            }
            
            if(wordFound)
            {
                foreach(var entry in wordTable)
                {
                    if(entry.Value > charTable[entry.Key])
                    {
                        l = 0;
                        break;
                    }
                }
            
                sum += l;
            }
        }
        
        return sum;
    }
}