public class Solution {
    public int MissingNumber(int[] nums) {
        if(nums.Length == 1)
        {
            if(nums[0] == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        var sortList = new SortedList<int, int>();
        
        foreach(var num in nums)
        {
            sortList.Add(num, 1);
        }
        
        var missingNum = nums.Length;
        var targetKey = 0;
        
        foreach(var entry in sortList)
        {
            if(entry.Key == targetKey)
            {
                targetKey++;
            }
            else
            {
                missingNum = targetKey;
                break;
            }
        }
        
        return missingNum;
    }
}