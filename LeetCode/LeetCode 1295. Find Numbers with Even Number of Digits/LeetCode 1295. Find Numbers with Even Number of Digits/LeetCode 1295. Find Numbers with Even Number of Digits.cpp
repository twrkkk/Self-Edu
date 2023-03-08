#include <iostream>
#include <vector>

using std::cin;
using std::cout;
using std::vector;

class Solution {
private:
    int count_digits(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result++;
            num /= 10;
        }
        return result;
    }
public:
    int findNumbers(vector<int>& nums) {
        int result = 0;
        for (auto e : nums)
            if (count_digits(e) % 2 == 0)
                result++;
        return result;
    }
};

int main()
{
    std::cout << "Hello World!\n";
}
