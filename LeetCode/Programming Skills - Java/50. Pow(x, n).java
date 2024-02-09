class Solution {
    public double myPow(double x, int n) {
        if (x == 1 || n == 0) {
            return 1;
        }

        if (n == 1) {
            return x;
        }

        if (x == -1 && n % 2 == 0) {
            return 1;
        }

        if (n == Integer.MIN_VALUE) {
            x = 1 / x;
            n = Integer.MAX_VALUE;
        } else if (n < 0) {
            x = 1 / x;
            n = Math.abs(n);
        }

        double result = 1;
        while (n != 0) {
            if (n % 2 == 1) {
                result *= x;
            }
            x *= x;
            n /= 2;
        }

        return result;
    }
}