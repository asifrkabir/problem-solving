class Solution {
    public int jump(int[] nums) {
        int jumps = 0;
        int finalJumpCapability = 0;

        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] == 0) {
                continue;
            }

            jumps++;
            
            finalJumpCapability += nums[i];

            if (finalJumpCapability >= nums.length - 1) {
                break;
            }

            int indexToJumpTo = i + nums[i];
            int bestJumpIndex = indexToJumpTo;

            for (int j = i + 1; j <= indexToJumpTo; j++) {
                if (j + nums[j] > finalJumpCapability) {
                    bestJumpIndex = j;
                    finalJumpCapability = j + nums[j];
                }
            }

            i = bestJumpIndex - 1;
            finalJumpCapability = i + 1;
        }

        return jumps;
    }
}