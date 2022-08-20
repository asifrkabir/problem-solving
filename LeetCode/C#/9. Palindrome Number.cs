public class Solution {
    public bool IsPalindrome(int x) {
        var num1 = x;
        var num2 = 0;
        
        while(x > 0)
        {
            num2 = num2 * 10 + x % 10;
            x /= 10;
        }
        
        return num1 == num2;  
    }
}