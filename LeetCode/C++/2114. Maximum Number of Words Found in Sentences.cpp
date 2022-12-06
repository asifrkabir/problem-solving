class Solution
{
public:
    int mostWordsFound(vector<string> &sentences)
    {
        int maxWords = 0;

        for (string s : sentences)
        {
            int wordCount = count(s.begin(), s.end(), ' ') + 1;
            maxWords = max(maxWords, wordCount);
        }

        return maxWords;
    }
};