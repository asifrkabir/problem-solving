class Solution {
    public boolean canJump(int[] nums) {
        if (nums[0] == 0 && nums.length > 1) {
            return false;
        }

        int furthestPossibleIndex = 0;

        for (int i = 0; i < nums.length - 1; i++) {
            int currentNum = nums[i];

            if (currentNum == 0 && furthestPossibleIndex <= i) {
                return false;
            }

            int currentFurthestPossibleIndex = i + currentNum;

            if (currentFurthestPossibleIndex > furthestPossibleIndex) {
                furthestPossibleIndex = currentFurthestPossibleIndex;
            }
        }

        return furthestPossibleIndex >= (nums.length - 1);
    }
}