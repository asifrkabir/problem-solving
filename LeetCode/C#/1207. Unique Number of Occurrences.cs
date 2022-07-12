public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var countTable = new Dictionary<int, int>();
        
        foreach(var num in arr)
        {
            if(!countTable.ContainsKey(num))
            {
                countTable.Add(num, 1);
            }
            else
            {
                countTable[num]++;
            }
        }
        
        var hashSet = new HashSet<int>();
        
        foreach(var entry in countTable)
        {
            if(!hashSet.Contains(entry.Value))
            {
                hashSet.Add(entry.Value);
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}