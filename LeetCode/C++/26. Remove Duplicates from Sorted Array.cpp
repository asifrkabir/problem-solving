class Solution
{
public:
    int removeDuplicates(vector<int> &nums)
    {
        int uniqueTotal = 1;
        int currentUnique = nums[0];
        int uniqueIndex = 0;

        for (int i = 1; i < nums.size(); i++)
        {
            if (nums[i] != currentUnique)
            {
                currentUnique = nums[i];
                nums[++uniqueIndex] = nums[i];
                uniqueTotal++;
            }
        }

        return uniqueTotal;
    }
};