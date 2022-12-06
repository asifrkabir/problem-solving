class Solution
{
public:
    int countMatches(vector<vector<string>> &items, string ruleKey, string ruleValue)
    {

        int count = 0;

        int indexToCheck = 0;
        if (ruleKey == "color")
        {
            indexToCheck = 1;
        }
        else if (ruleKey == "name")
        {
            indexToCheck = 2;
        }

        for (int i = 0; i < items.size(); i++)
        {
            if (items[i][indexToCheck] == ruleValue)
            {
                count++;
            }
        }

        return count;
    }
};