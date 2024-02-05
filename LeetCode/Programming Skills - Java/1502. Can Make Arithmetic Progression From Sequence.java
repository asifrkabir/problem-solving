class Solution {
    public boolean canMakeArithmeticProgression(int[] arr) {
        if (arr.length == 2) {
            return true;
        } else {
            Arrays.sort(arr);

            int difference = arr[1] - arr[0];

            for (int i = 2; i < arr.length; i++) {
                if (arr[i] - arr[i - 1] != difference) {
                    return false;
                }
            }

            return true;
        }
    }
}