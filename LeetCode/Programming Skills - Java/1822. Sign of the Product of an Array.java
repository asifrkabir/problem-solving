class Solution {
    public int arraySign(int[] nums) {
        boolean positive = true;

        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 0) {
                return 0;
            } else if (nums[i] < 0) {
                positive = !positive;
            }
        }

        if (positive) {
            return 1;
        } else {
            return -1;
        }
    }
}