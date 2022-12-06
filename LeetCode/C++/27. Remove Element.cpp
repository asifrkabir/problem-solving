class Solution
{
public:
    int removeElement(vector<int> &nums, int val)
    {
        int uniqueIndex = 0;
        int uniqueTotal = 0;

        for (int i = 0; i < nums.size(); i++)
        {
            if (nums[i] != val)
            {
                uniqueTotal++;
                nums[uniqueIndex++] = nums[i];
            }
        }

        return uniqueTotal;
    }
};