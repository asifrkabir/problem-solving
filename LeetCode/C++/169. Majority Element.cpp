class Solution
{
public:
    int majorityElement(vector<int> &nums)
    {
        int count = 0;
        int result = 0;

        for (auto num : nums)
        {
            if (count == 0)
            {
                result = num;
            }

            if (num == result)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return result;
    }
};