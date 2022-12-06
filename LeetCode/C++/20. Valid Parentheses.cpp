class Solution
{
public:
    bool isValid(string s)
    {
        stack<char> parenthesesStack;
        bool valid = 1;

        for (int i = 0; i < s.length(); i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                parenthesesStack.push(s[i]);
            }
            else if (parenthesesStack.empty())
            {
                valid = 0;
                break;
            }
            else if (s[i] == ')')
            {
                if (parenthesesStack.top() == '(')
                {
                    parenthesesStack.pop();
                }
                else
                {
                    valid = 0;
                    break;
                }
            }
            else if (s[i] == '}')
            {
                if (parenthesesStack.top() == '{')
                {
                    parenthesesStack.pop();
                }
                else
                {
                    valid = 0;
                    break;
                }
            }
            else if (s[i] == ']')
            {
                if (parenthesesStack.top() == '[')
                {
                    parenthesesStack.pop();
                }
                else
                {
                    valid = 0;
                    break;
                }
            }
        }

        if (!parenthesesStack.empty())
        {
            return 0;
        }

        return valid;
    }
};