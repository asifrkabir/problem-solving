public class Solution {
    public int Fib(int n) {
        if(n == 0 || n == 1)
        {
            return n;
        }
        
        return Fib(n - 1) + Fib(n - 2);
    }
}