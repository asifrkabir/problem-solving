class Solution
{
public:
    string reverseWords(string s)
    {
        vector<string> words;
        stringstream streamData(s);
        string word;
        string output;

        while (getline(streamData, word, ' '))
        {
            words.push_back(word);
        }

        int n = words.size();

        for (int i = n - 1; i >= 0; i--)
        {
            if (words[i] == "")
            {
                continue;
            }

            if (i == 0)
            {
                output += words[i];
            }
            else
            {
                output += words[i] + " ";
            }
        }

        if (output[output.length() - 1] == ' ')
        {
            output = output.substr(0, output.length() - 1);
        }

        return output;
    }
};