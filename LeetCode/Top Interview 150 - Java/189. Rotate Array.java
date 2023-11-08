class Solution {
    public void rotate(int[] nums, int k) {
        int n = nums.length;
        int[] tempArr = new int[n];

        k = k % n;

        for (int i = 0; i < n; i++) {
            tempArr[(i + k) % n] = nums[i];
        }

        System.arraycopy(tempArr, 0, nums, 0, n);
    }
}