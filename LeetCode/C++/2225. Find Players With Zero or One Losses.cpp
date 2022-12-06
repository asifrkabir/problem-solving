class Solution
{
public:
    vector<vector<int>> findWinners(vector<vector<int>> &matches)
    {
        map<int, int> loseMap;
        vector<int> answerZero;
        vector<int> answerOne;
        vector<vector<int>> answer;

        for (int i = 0; i < matches.size(); i++)
        {
            int winner = matches[i][0];
            int loser = matches[i][1];

            if (loseMap.find(loser) != loseMap.end())
            {
                loseMap[loser]++;
            }
            else
            {
                loseMap.insert({loser, 1});
            }

            if (loseMap.find(winner) == loseMap.end())
            {
                loseMap.insert({winner, 0});
            }
        }

        for (auto keyValue : loseMap)
        {
            if (keyValue.second == 0)
            {
                answerZero.push_back(keyValue.first);
            }
            else if (keyValue.second == 1)
            {
                answerOne.push_back(keyValue.first);
            }
        }

        answer.push_back(answerZero);
        answer.push_back(answerOne);

        return answer;
    }
};