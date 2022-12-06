class Solution
{
public:
    vector<int> smallerNumbersThanCurrent(vector<int> &nums)
    {
        unordered_map<int, int> numCount;
        vector<int> ans;
        vector<int> sorted(nums.begin(), nums.end());
        sort(sorted.begin(), sorted.end(), greater<int>());

        for (int num : nums)
        {
            if (numCount.find(num) == numCount.end())
            {
                numCount.insert({num, 1});
            }
            else
            {
                numCount[num]++;
            }
        }

        for (int i = 0; i < nums.size(); i++)
        {
            int smaller = nums.size() - (find(sorted.begin(), sorted.end(), nums[i]) - sorted.begin()) - numCount[nums[i]];
            ans.push_back(smaller);
        }

        return ans;
    }
};