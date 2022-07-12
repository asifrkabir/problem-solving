public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var stringCount = new Dictionary<string, int>();
        var uniqueList = new List<string>();
        
        foreach(var s in arr)
        {
            if(!stringCount.ContainsKey(s))
            {
                stringCount.Add(s, 1);
                uniqueList.Add(s);
            }
            else
            {
                if(stringCount[s] == 1)
                {
                    uniqueList.Remove(s);
                }
                stringCount[s]++;
            }
        }
        
        if(uniqueList.Count >= k)
        {
            return uniqueList[k - 1];
        }
        else
        {
            return "";
        }
    }
}