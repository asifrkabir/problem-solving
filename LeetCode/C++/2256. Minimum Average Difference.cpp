class Solution
{
public:
    int minimumAverageDifference(vector<int> &nums)
    {
        long long totalSum = 0;
        long long prefixSum = 0;
        int minIndex = 0;
        int minDiff = INT_MAX;
        int n = nums.size();

        for (int num : nums)
        {
            totalSum += num;
        }

        for (int i = 0; i < n; i++)
        {
            prefixSum += nums[i];
            totalSum -= nums[i];
            int preCount = i + 1;
            int postCount = n - preCount;

            int preAvg = prefixSum / preCount;
            int postAvg = (postCount == 0) ? 0 : (totalSum / postCount);

            int diff = abs(preAvg - postAvg);

            if (diff < minDiff)
            {
                minDiff = diff;
                minIndex = i;
            }
        }

        return minIndex;
    }
};