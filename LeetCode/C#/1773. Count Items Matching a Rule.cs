public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        var numOfMatches = 0;
        var indexToSearch = 0;
        
        if(ruleKey == "color")
        {
            indexToSearch = 1;
        }
        else if(ruleKey == "name")
        {
            indexToSearch = 2;
        }
        
        for(var i = 0; i < items.Count(); i++)
        {
            if(string.Equals(items[i][indexToSearch], ruleValue))
            {
                numOfMatches++;
            }
        }
        
        return numOfMatches;
    }
}