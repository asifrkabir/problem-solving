public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        var numCount = new Dictionary<int, int>();
        var outputList = new List<int>();
        
        foreach(var num in new HashSet<int>(nums1))
        {
            if(numCount.ContainsKey(num))
            {
                continue;
            }
            else
            {
                numCount.Add(num, 1);
            }
        }
        
        foreach(var num in new HashSet<int>(nums2))
        {
            if(numCount.ContainsKey(num))
            {
                if(numCount[num] == 1)
                {
                    numCount[num]++;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                numCount.Add(num, 1);
            }
        }
        
        foreach(var num in new HashSet<int>(nums3))
        {
            if(numCount.ContainsKey(num))
            {
                if(numCount[num] == 1 || numCount[num] == 2)
                {
                    numCount[num]++;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                numCount.Add(num, 1);
            }
        }
        
        foreach(var num in numCount)
        {
            if(num.Value >= 2)
            {
                outputList.Add(num.Key);
            }
        }
        
        return outputList;
    }
}