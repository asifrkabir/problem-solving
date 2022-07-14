public class Solution {
    public IList<int> Intersection(int[][] nums) {
        var numDict = new Dictionary<int, int>();
        var numList = new SortedList<int, int>();
        
        for(var i = 0; i < nums.Length; i++)
        {
            for(var j = 0; j < nums[i].Length; j++)
            {
                if(!numDict.ContainsKey(nums[i][j]))
                {
                    numDict.Add(nums[i][j], 1);
                }
                else
                {
                    numDict[nums[i][j]]++;
                }
                
                if(i == nums.Length - 1 && numDict[nums[i][j]] == nums.Length)
                    {
                        numList.Add(nums[i][j], 1);
                    }
            }
        }
        
        return numList.Keys.ToList();
    }
}