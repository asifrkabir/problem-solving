public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        List<int> indexList = new List<int>{};
        
        Array.Sort(nums);
        
        var indexOfTarget = Array.IndexOf(nums, target);
        
        if(indexOfTarget == -1) return indexList;
        
        for(var i = indexOfTarget; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                indexList.Add(i);
            }
            else break;
        }
        
        return indexList;
    }
}