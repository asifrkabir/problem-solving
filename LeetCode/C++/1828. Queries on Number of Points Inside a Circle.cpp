class Solution
{
public:
    vector<int> countPoints(vector<vector<int>> &points, vector<vector<int>> &queries)
    {
        vector<int> numOfPoints;

        for (int i = 0; i < queries.size(); i++)
        {
            int x = queries[i][0];
            int y = queries[i][1];
            int r = queries[i][2];
            int p = 0;

            for (int j = 0; j < points.size(); j++)
            {
                double distance = sqrt(
                    pow((points[j][0] - x), 2) +
                    pow((points[j][1] - y), 2));

                if (distance <= r)
                {
                    p++;
                }
            }

            numOfPoints.push_back(p);
        }

        return numOfPoints;
    }
};