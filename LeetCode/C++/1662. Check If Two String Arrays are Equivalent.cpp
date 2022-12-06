class Solution
{
public:
    bool arrayStringsAreEqual(vector<string> &word1, vector<string> &word2)
    {

        auto word1Pointer = word1.begin();
        auto word1End = word1.end();
        auto word2Pointer = word2.begin();
        auto word2End = word2.end();

        auto c1Pointer = word1Pointer->begin();
        auto c1End = word1Pointer->end();
        auto c2Pointer = word2Pointer->begin();
        auto c2End = word2Pointer->end();

        while (*c1Pointer == *c2Pointer)
        {
            c1Pointer++;
            c2Pointer++;

            if (c1Pointer == c1End)
            {
                word1Pointer++;
            }

            if (c2Pointer == c2End)
            {
                word2Pointer++;
            }

            if (word1Pointer == word1End || word2Pointer == word2End)
            {
                break;
            }

            if (c1Pointer == c1End)
            {
                c1Pointer = word1Pointer->begin();
                c1End = word1Pointer->end();
            }

            if (c2Pointer == c2End)
            {
                c2Pointer = word2Pointer->begin();
                c2End = word2Pointer->end();
            }
        }

        return (word1Pointer == word1End && word2Pointer == word2End);
    }
};