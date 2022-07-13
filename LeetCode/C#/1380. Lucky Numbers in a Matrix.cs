public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        var luckyNums = new List<int>();
        var minNums = new List<int>();
        
        for(var i = 0; i < matrix.Length; i++)
        {
            minNums.Add(matrix[i].Min());
        }
        
        for(var i = 0; i < matrix[0].Length; i++)
        {
            var maxArr = new int[matrix.Length];
            
            for(var j = 0; j < matrix.Length; j++)
            {
                maxArr[j] = matrix[j][i];
            }
            
            var max = maxArr.Max();
            
            if(minNums.Contains(max))
            {
                luckyNums.Add(max);
            }
        }
        
        return luckyNums;
    }
}