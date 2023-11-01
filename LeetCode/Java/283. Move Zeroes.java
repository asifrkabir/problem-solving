class Solution {
    public void moveZeroes(int[] nums) {
        for(int i = 0, lastNonZeroElementIndex = 0; i < nums.length; i++) {
            if(nums[i] != 0) {
                int temp = nums[i];
                nums[i] = nums[lastNonZeroElementIndex];
                nums[lastNonZeroElementIndex++] = temp;
            }
        }
    }
}