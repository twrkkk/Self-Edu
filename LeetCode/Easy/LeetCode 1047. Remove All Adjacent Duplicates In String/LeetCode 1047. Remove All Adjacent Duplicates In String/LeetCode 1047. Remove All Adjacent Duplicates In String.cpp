#include <iostream>
#include <stack>
#include <string>
#include <algorithm>

using std::string;
using std::stack;

class Solution
{
public:
    string removeDuplicates(string s)
    {
        stack<char> stack;
        int size = s.size();
        for (int i = 0; i < size; i++)
        {
            if (!stack.empty())
                if (s[i] == stack.top())
                    stack.pop();
                else
                    stack.push(s[i]);
            else
                stack.push(s[i]);
        }

        string result;
        while (!stack.empty())
        {
            result += stack.top();
            stack.pop();
        }
        std::reverse(result.begin(), result.end());

        return result;
    }
};

int main()
{
    Solution s;
    std::cout << s.removeDuplicates("abbaca");
}
