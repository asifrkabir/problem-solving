class Solution {
    public boolean check(int[] nums) {
        int n = nums.length;

        if (n == 0) return true;

        int minNum = nums[0];
        int minIndex = 0;

        for (int i = 1; i < n; i++) {
            if (nums[i] == nums[i - 1]) continue;

            if (nums[i] <= minNum) {
                minNum = nums[i];
                minIndex = i;
            }
        }

        int count = 0;
        int index = minIndex;

        while (count < n - 1) {
            if (index >= n - 1) {
                if (nums[index] > nums[0]) return false;

                index = 0;
                count++;
                continue;
            }

            if (nums[index + 1] < nums[index]) {
                return false;
            }
            index++;
            count++;
        }

        return true;
    }
}