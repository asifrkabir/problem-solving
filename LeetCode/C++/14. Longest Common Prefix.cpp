class Solution
{
public:
    string longestCommonPrefix(vector<string> &strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.size(); i++)
        {
            string currentPrefix = commonPrefix(prefix, strs[i]);
            prefix = currentPrefix;
        }

        return prefix;
    }

    string commonPrefix(string str1, string str2)
    {
        string prefix = "";
        int len = min(str1.length(), str2.length());

        for (int i = 0; i < len; i++)
        {
            if (str1[i] == str2[i])
            {
                prefix += str1[i];
            }
            else
            {
                break;
            }
        }

        return prefix;
    }
};