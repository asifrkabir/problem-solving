public class Solution {
    public int MinimumSum(int num) {
        var numArr = new int[4];
        var numString = num.ToString();
        
        for(var i = 0; i < numArr.Length; i++)
        {
            numArr[i] = numString[i] - '0';
        }
        
        Array.Sort(numArr);
        
        var num1 = numArr[0].ToString() + numArr[2].ToString();
        var num2 = numArr[1].ToString() + numArr[3].ToString();
        
        var sum = int.Parse(num1) + int.Parse(num2);
        
        return sum;
    }
}