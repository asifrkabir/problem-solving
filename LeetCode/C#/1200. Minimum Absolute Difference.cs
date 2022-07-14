public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        
        var minDiff = int.MaxValue;
        
        for(var i = 0; i < arr.Length - 1; i++)
        {
            var diff = Math.Abs(arr[i + 1] - arr[i]);
            
            if(diff < minDiff)
            {
                minDiff = diff;
            }
        }
        
        var numList = new List<IList<int>>();
        
        for(var i = 0; i < arr.Length - 1; i++)
        {
            if(Math.Abs(arr[i + 1] - arr[i]) == minDiff)
            {
                var pair = new List<int>();
                pair.Add(arr[i]);
                pair.Add(arr[i + 1]);
                numList.Add(pair);
            }
        }
        
        return numList;
    }
}