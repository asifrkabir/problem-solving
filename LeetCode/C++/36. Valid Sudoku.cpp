class Solution
{
public:
    bool isValidSudoku(vector<vector<char>> &board)
    {
        bool valid = 1;

        valid = checkRows(board);

        if (valid)
        {
            valid = checkColumns(board);

            if (valid)
            {
                valid = checkBox(board);
            }
        }

        return valid;
    }

    bool checkRows(vector<vector<char>> &board)
    {
        bool valid = 1;

        for (int i = 0; i < 9; i++)
        {
            if (valid == 0)
            {
                break;
            }

            int nums[10] = {0};

            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                int num = int(board[i][j] - '0');

                if (nums[num] == 0)
                {
                    nums[num] = 1;
                }
                else
                {
                    valid = 0;
                    break;
                }
            }
        }

        return valid;
    }

    bool checkColumns(vector<vector<char>> &board)
    {
        bool valid = 1;

        for (int i = 0; i < 9; i++)
        {
            if (valid == 0)
            {
                break;
            }

            int nums[10] = {0};

            for (int j = 0; j < 9; j++)
            {
                if (board[j][i] == '.')
                {
                    continue;
                }

                int num = int(board[j][i] - '0');

                if (nums[num] == 0)
                {
                    nums[num] = 1;
                }
                else
                {
                    valid = 0;
                    break;
                }
            }
        }

        return valid;
    }

    bool checkBox(vector<vector<char>> &board)
    {
        bool valid = 1;

        int start = 0;
        int start1 = 0;

        for (int i = 0; i < 9; i++)
        {
            if (valid == 0)
            {
                break;
            }

            int nums[10] = {0};

            for (int j = start; j < start + 3; j++)
            {
                if (valid == 0)
                {
                    break;
                }

                for (int k = start1; k < start1 + 3; k++)
                {
                    if (board[j][k] == '.')
                    {
                        continue;
                    }

                    int num = int(board[j][k] - '0');

                    if (nums[num] == 0)
                    {
                        nums[num] = 1;
                    }
                    else
                    {
                        valid = 0;
                        break;
                    }
                }
            }

            start1 = (start1 + 3) % 9;

            if ((i + 1) % 3 == 0)
            {
                start += 3;
            }
        }

        return valid;
    }
};