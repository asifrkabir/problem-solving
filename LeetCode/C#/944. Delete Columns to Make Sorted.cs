public class Solution {
    public int MinDeletionSize(string[] strs) {
        var deletes = 0;
        
        for(var i = 0; i < strs[0].Length; i++)
        {
            for(var j = 0; j < strs.Length - 1; j++)
            {
                if(strs[j][i] > strs[j + 1][i])
                {
                    deletes++;
                    break;
                }
            }
        }
        
        return deletes;
    }
}