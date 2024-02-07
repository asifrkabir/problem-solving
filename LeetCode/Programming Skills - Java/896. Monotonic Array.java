class Solution {
    public boolean isMonotonic(int[] nums) {
        if (nums.length <= 2) {
            return true;
        }

        if (nums[0] < nums[1]) {
            for (int i = 2; i < nums.length; i++) {
                if (nums[i] < nums[i - 1]) {
                    return false;
                }
            }
        } else if (nums[0] > nums[1]) {
            for (int i = 2; i < nums.length; i++) {
                if (nums[i] > nums[i - 1]) {
                    return false;
                }
            }
        } else {
            int lastDifferenceType = 0; // 0 = equal, 1 = increasing, 2 = decreasing

            for (int i = 2; i < nums.length; i++) {
                if (nums[i] > nums[i - 1] && lastDifferenceType == 2) {
                    return false;
                } else if (nums[i] < nums[i - 1] && lastDifferenceType == 1) {
                    return false;
                }

                if (lastDifferenceType == 0) {
                    if (nums[i] > nums[i - 1]) {
                        lastDifferenceType = 1;
                    } else if (nums[i] < nums[i - 1]) {
                        lastDifferenceType = 2;
                    } else {
                        lastDifferenceType = 0;
                    }
                }
            }
        }

        return true;
    }
}