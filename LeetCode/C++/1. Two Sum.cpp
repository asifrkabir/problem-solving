class Solution
{
public:
    vector<int> twoSum(vector<int> &nums, int target)
    {
        map<int, int> numMap;

        for (int i = 0; i < nums.size(); i++)
        {
            int complement = target - nums[i];

            if (numMap.count(complement))
            {
                return {i, numMap[complement]};
            }

            numMap.insert({nums[i], i});
        }

        return {};
    }
};