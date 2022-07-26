public class Solution {
    public int TitleToNumber(string columnTitle) {
        var columnNum = 0; 
        
        for(var i = 0; i < columnTitle.Length; i++)
        {
            columnNum *= 26;
            columnNum += columnTitle[i] - 64;
        }
        
        return columnNum;
    }
}