class Solution {
    public int removeDuplicates(int[] nums) {
        int k = 1;
        int currentNum = nums[0];

        for(int i = 1; i < nums.length; i++) {
            if(nums[i] != currentNum) {
                nums[k] = nums[i];
                currentNum = nums[i];
                k++;
            }
        }

        return k;
    }
}