#include <iostream>
#include <sstream>
#include <string>
#include <algorithm>

using std::string;

class Solution {
public:
	string reverseWords(string s) {
		int size = s.size();
		for (int i = 0; i < size; i++)
		{
			if (s[i] != ' ')
			{
				int j = i;
				while (j < size && s[j] != ' ')
					++j;
				std::reverse(s.begin() + i, s.begin() + j);
				i = j;
			}
		}
		return s;
	}
};

int main()
{
}
