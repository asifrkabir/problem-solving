class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {
        int maxConsecutiveOnes = 0;
        int currentConsecutiveOneCount = 0;

        for (int num : nums) {
            if (num == 1) {
                currentConsecutiveOneCount++;

                if (maxConsecutiveOnes < currentConsecutiveOneCount) {
                    maxConsecutiveOnes = currentConsecutiveOneCount;
                }
            } else {
                currentConsecutiveOneCount = 0;
            }
        }

        return maxConsecutiveOnes;
    }
}