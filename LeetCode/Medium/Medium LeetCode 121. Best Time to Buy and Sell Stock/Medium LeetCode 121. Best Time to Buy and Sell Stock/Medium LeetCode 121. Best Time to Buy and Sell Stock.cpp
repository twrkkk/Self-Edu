#include <iostream>
#include <vector>

using std::cin;
using std::cout;
using std::vector;

class Solution {
public:
	int maxProfit(vector<int>& prices) {
		int min = prices[0], res = 0;
		for (int i = 0; i < prices.size(); i++)
		{
			min = std::min(min, prices[i]);
			res = std::max(res, prices[i] - min);
		}
		return res;
	}
};

int main()
{
	Solution s;
	vector<int> v{ 7,1,5,3,6,4 };
	cout<<s.maxProfit(v);
}
