class Solution
{
public:
    int uniqueMorseRepresentations(vector<string> &words)
    {
        set<string> wordSet;

        for (string word : words)
        {
            string morseCode = convertToMorse(word);

            if (wordSet.find(morseCode) == wordSet.end())
            {
                wordSet.insert(morseCode);
            }
        }

        return wordSet.size();
    }

    string convertToMorse(string word)
    {
        string morseCode;
        vector<string> morseCodes = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

        for (char c : word)
        {
            int idx = int(c) - 97;
            morseCode += morseCodes[idx];
        }

        return morseCode;
    }
};