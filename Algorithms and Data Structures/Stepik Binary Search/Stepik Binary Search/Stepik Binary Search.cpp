#include <iostream>

using std::cin;
using std::cout;

int find_elem(int* arr, int l, int r, int key)
{
	int m;
	while (l <= r)
	{
		m = l + (r - l) / 2;
		if (arr[m] == key)
			return m;
		else if (arr[m] > key)
			r = m - 1;
		else
			l = m + 1;
	}
	return -1;
}

int main()
{
	int size;
	cin >> size;
	int* arr = new int[size];
	for (int i = 0; i < size; i++)
		cin >> arr[i];

	int k;
	cin >> k;
	for (int i = 0; i < k; i++)
	{
		int key;
		cin >> key;
		int res = find_elem(arr, 0, size - 1, key);
		cout << ((res >= 0) ? res + 1 : -1) << ' ';
	}
}
