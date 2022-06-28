public class Solution {
    public string GenerateTheString(int n) {
        if(n % 2 == 0)
        {
            return string.Concat(Enumerable.Repeat("a", n - 1)) + "b";
        }
        
        return string.Concat(Enumerable.Repeat("a", n));
    }
}