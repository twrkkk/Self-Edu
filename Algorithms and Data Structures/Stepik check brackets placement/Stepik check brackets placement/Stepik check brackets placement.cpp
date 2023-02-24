#include <iostream>
#include <string>
#include <stack>

using std::cin;
using std::cout;

using pair = std::pair<char, int>;

int main()
{

	std::stack<pair> s;
	std::string str;
	std::getline(cin, str);
	//cin >> str;
	int size = str.size();
	//s.push(pair(str[0], 0));
	int i = 0;
	bool is_correct = true;

	int answer = -1;

	while (i < size && is_correct)
	{
		if (str[i] == '(' || str[i] == '[' || str[i] == '{')
			s.push(pair(str[i], i+1));
		else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
		{
			pair top;
			if (!s.empty())
			{
				top = s.top();
				s.pop();
				answer = top.second;
			}
			else is_correct = false;

			switch (top.first)
			{
			case '(':
				if (str[i] != ')')
				{
					is_correct = false;
					answer = top.second;
				}
				break;
			case '[':
				if (str[i] != ']')
				{
					is_correct = false;
					answer = top.second;
				}
				break;
			case '{':
				if (str[i] != '}')
				{
					is_correct = false;
					answer = top.second;
				}
				break;
			default:
				is_correct = false;
				break;
			}
		}
		++i;
	}
	if (is_correct && s.empty() && i == size)
		cout << "Success" << '\n';
	else if (is_correct && i == size)
		cout << s.top().second << '\n';
	else if (i == size)
		cout << size << '\n';
}
