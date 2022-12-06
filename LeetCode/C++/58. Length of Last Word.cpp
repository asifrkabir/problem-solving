class Solution
{
public:
    int lengthOfLastWord(string s)
    {
        int lastIndex = s.find_last_not_of(" ");
        string word = "";

        for (int i = lastIndex; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                break;
            }

            word += s[i];
        }

        return word.length();
    }
};