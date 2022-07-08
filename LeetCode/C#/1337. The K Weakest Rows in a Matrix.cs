public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var weakestRows = new int[k];
        
        var rowList = new Dictionary<int, int>();
        
        for(var i = 0; i < mat.Length; i++)
        {
            rowList.Add(i, mat[i].Sum());
        }
        
        var j = 0;
        
        foreach(var row in rowList.OrderBy(key => key.Value))
        {
            weakestRows[j] = row.Key;
            j++;
            
            if(j == k)
            {
                break;
            }
        }
        
        return weakestRows;
    }
}