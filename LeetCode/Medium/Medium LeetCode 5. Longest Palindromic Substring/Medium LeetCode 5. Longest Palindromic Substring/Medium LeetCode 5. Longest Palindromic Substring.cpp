#include <iostream>
#include <string>
using std::cin;
using std::cout;
using std::string;

class Solution {
public:
	string longestPalindrome(string s) {
		if (s.size() < 2)
			return s;
		string res = "";
		int size = s.size();
		int  l = 0, r = 0;
		for (int i = 0; i < size; i++)
		{
			l = i;
			r = i;
			while (l >= 0 && r <= size - 1 && s[l] == s[r])
			{
				if (r - l + 1 > res.size())
					res = s.substr(l, r - l + 1);
				--l;
				++r;
			}
			
		}

		l = 0, r = 0;
		for (int i = 0; i < size; i++)
		{
			l = i;
			r = i + 1;
			while (l >= 0 && r <= size - 1 && s[l] == s[r])
			{
				if (r - l + 1 > res.size())
					res = s.substr(l, r - l + 1);
				--l;
				++r;
			}
		}
		return res;
	}
};

int main()
{
	Solution s;
	cout << s.longestPalindrome("ac");
}
