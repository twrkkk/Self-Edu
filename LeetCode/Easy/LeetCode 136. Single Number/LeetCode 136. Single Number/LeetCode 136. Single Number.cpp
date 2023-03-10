#include <iostream>
#include <vector>

using std::cin;
using std::cout;
using std::vector;

class Solution {
public:
	int singleNumber(vector<int>& nums) {
		int result = 0;
		for (auto e : nums)
			result ^= e;
		return result;
	}
};

int main()
{
	Solution s;
	vector<int> v{ 4,1,2,1,2 };
	std::cout << (s.singleNumber(v));
}
