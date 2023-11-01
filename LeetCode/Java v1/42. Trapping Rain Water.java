class Solution {
    public int trap(int[] height) {
        int currentLeftIndex = 0;
        int currentRightIndex = height.length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int totalRainwaterTrapped = 0;

        while (currentLeftIndex < currentRightIndex) {
            if (height[currentLeftIndex] < height[currentRightIndex]) {
                leftMax = Math.max(leftMax, height[currentLeftIndex]);
                totalRainwaterTrapped += leftMax - height[currentLeftIndex];
                currentLeftIndex++;
            }
            else {
                rightMax = Math.max(rightMax, height[currentRightIndex]);
                totalRainwaterTrapped += rightMax - height[currentRightIndex];
                currentRightIndex--;
            }
        }

        return totalRainwaterTrapped;
    }
}