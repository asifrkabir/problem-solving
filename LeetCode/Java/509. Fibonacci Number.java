class Solution {
    public int fib(int n) {
        if (n <= 1) return n;

        int secondLast = 0;
        int last = 1;
        int current = last + secondLast;

        for (int i = 2; i <= n; i++) {
            current = last + secondLast;
            secondLast = last;
            last = current;
        }

        return current;
    }
}