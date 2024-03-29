class Solution
{
public:
    vector<int> createTargetArray(vector<int> &nums, vector<int> &index)
    {
        vector<int> ans;

        for (int i = 0; i < nums.size(); i++)
        {
            int idx = index[i];
            int val = nums[i];
            ans.insert(ans.begin() + idx, val);
        }

        return ans;
    }
};