public class Solution {
    public int Maximum69Number (int num) {
        var numString = num.ToString();
        
        if(!numString.Contains('6'))
        {
            return num;
        }
        else
        {
            var index1 = numString.IndexOf('6');
            var maxNum = numString.Substring(0, index1) + "9" + numString.Substring(index1 + 1);
            return int.Parse(maxNum);
        }
    }
}