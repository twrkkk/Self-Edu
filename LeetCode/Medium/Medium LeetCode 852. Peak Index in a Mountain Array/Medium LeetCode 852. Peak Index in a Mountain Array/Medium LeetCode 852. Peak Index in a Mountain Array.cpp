#include <iostream>
#include <vector>

using std::cin;
using std::cout;
using std::vector;

class Solution {
public:
	int peakIndexInMountainArray(vector<int>& arr) {
		int l = 0, r = arr.size() - 1;
		int middle = 0;
		while (l <= r)
		{
			middle = l + (r - l) / 2;
			if (middle == 0) middle = 1;
			if (arr[middle] > arr[middle - 1] && arr[middle] > arr[middle + 1])
				return middle;
			else if (arr[middle] > arr[middle - 1])
				l = middle + 1;
			else
				r = middle - 1;
		}
		return -1;
	}
};

int main()
{
	Solution s;
	vector<int> v{ 3,5,3,2,0 };
	std::cout << s.peakIndexInMountainArray(v);
}
