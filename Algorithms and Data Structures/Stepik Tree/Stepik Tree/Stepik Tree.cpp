#include <iostream>
#include <vector>
#include <queue>

using std::cin;
using std::cout;

int add_to_queue(std::queue<int>& q, std::vector<int>& v)
{
	int size = v.size();
	for (int i = 0; i < size; i++)
		q.push(v[i]);
	return size;
}

int main()
{
	int n;
	cin >> n;
	int value;
	int root;
	std::vector<std::vector<int>> parents(n);
	for (int i = 0; i < n; i++)
	{
		cin >> value;
		if (value != -1)
			parents[value].push_back(i);
		else
			root = i;
	}
	
	std::queue<int> q;
	int count = parents[root].size();
	int level = 1;
	add_to_queue(q, parents[root]);
	while (!q.empty())
	{
		int countNext = 0;
		for (int i = 0; i < count; i++)
		{
			countNext += add_to_queue(q, parents[q.front()]);
			q.pop();
		}
		++level;
		count = countNext;
	}
	cout << level;
}