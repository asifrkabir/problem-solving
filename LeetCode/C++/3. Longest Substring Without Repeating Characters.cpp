class Solution
{
public:
    int lengthOfLongestSubstring(string s)
    {
        int startIndex = 0;
        int longestLength = 0;

        while (startIndex < s.length())
        {
            string currentString = "";
            map<char, int> charMap;

            for (int i = startIndex; i < s.length(); i++)
            {
                if (charMap.find(s[i]) != charMap.end())
                {
                    break;
                }
                else
                {
                    charMap.insert({s[i], 1});
                    currentString += s[i];
                }
            }

            if (currentString.length() > longestLength)
            {
                longestLength = currentString.length();
            }

            startIndex++;
        }

        return longestLength;
    }
};