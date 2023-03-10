#include <iostream>
#include <map>

using std::cin;
using std::cout;
using std::string;

class Solution {
public:
    char findTheDifference2(string s, string t)
    {
        for (int i = 0; i < s.size(); i++)
            t[i + 1] += t[i] - s[i];
        return t[t.size() - 1];
    }
    char findTheDifference(string s, string t) {
        std::map<char, int> map;
        std::map<char, int>::iterator it;
        for (char c : s)
        {
            it = map.find(c);
            if (it != map.end())
                it->second++;
            else
                map.insert(std::pair<char, int>(c, 1));
        }

        for (int i = 0; i < t.length(); i++)
        {
            it = map.find(t[i]);
            if (it != map.end())
            {
                it->second--;
                if (it->second < 0)
                    return t[i];
            }
            else
                return t[i];
        }
        return '\0';
    }
};

int main()
{
    std::cout << "Hello World!\n";
}
