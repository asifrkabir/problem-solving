class Solution {
    public int removeDuplicates(int[] nums) {
        int k = 1;
        int currentNumCount = 1;

        for(int i = 1; i < nums.length; i++) {
            if(nums[i] == nums[i - 1]) {
                if(currentNumCount < 2) {
                    nums[k] = nums[i];
                    k++;
                    currentNumCount++;
                }
            }
            else {
                nums[k] = nums[i];
                currentNumCount = 1;
                k++;
            }
        }

        return k;
    }
}