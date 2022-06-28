public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var charDictionary = new Dictionary<char, int>();
        
        foreach(var c in s)
        {
            if(charDictionary.ContainsKey(c))
            {
                charDictionary[c]++;
            }
            else
            {
                charDictionary.Add(c, 1);
            }
        }
        
        var checkCount = charDictionary.First().Value;
        
        foreach(var entry in charDictionary)
        {
            if(entry.Value != checkCount) return false;
        }
        
        return true;
    }
}