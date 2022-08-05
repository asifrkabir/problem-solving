public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var output = new int[arr1.Length];
        var numSequence = new Dictionary<int, int>();
        var remaining = new SortedList<int, int>();
        
        foreach(var num in arr2)
        {
            numSequence.Add(num, 0);
        }
        
        foreach(var num in arr1)
        {
            if(!numSequence.ContainsKey(num))
            {
                if(!remaining.ContainsKey(num))
                {
                    remaining.Add(num, 1);
                }
                else
                {
                    remaining[num]++;
                }
            }
            else
            {
                numSequence[num]++;
            }
        }
        
        var index = 0;
        
        foreach(var entry in numSequence)
        {
            for(var i = 0; i < entry.Value; i++)
            {
                output[index] = entry.Key;
                index++;
            }
        }
        
        foreach(var entry in remaining)
        {
            for(var i = 0; i < entry.Value; i++)
            {
                output[index] = entry.Key;
                index++;
            }
        }
        
        return output;
    }
}