class Solution
{
public:
    int romanToInt(string s)
    {
        int result = 0;
        map<char, int> symbolMap = {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}};

        for (int i = 0; i < s.size(); i++)
        {
            int val1 = symbolMap[s[i]];

            if (i != s.size() - 1)
            {

                int val2 = symbolMap[s[i + 1]];

                if (val1 < val2)
                {
                    result += (val2 - val1);
                    i++;
                }
                else
                {
                    result += val1;
                }
            }
            else
            {
                result += val1;
            }
        }

        return result;
    }
};