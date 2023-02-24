//#include <iostream>
//
//int get_length_of_longest_divisible_subsequence(int* arr, int size)
//{
//	int* d = new int[size];
//	for (int i = 0; i < size; i++)
//	{
//		d[i] = 1;
//		for (int j = 0; j < i; j++)
//			if (d[j] + 1 > d[i] && arr[i] % arr[j] == 0)
//				d[i] = d[j] + 1;
//	}
//	int max_elem = d[0];
//	for (int i = 1; i < size; i++)
//		max_elem = std::max(max_elem, d[i]);
//	return max_elem;
//}
//
//int main()
//{
//	int n;
//	std::cin >> n;
//	int* arr = new int[n];
//	for (int i = 0; i < n; i++)
//		std::cin >> arr[i];
//	std::cout << get_length_of_longest_divisible_subsequence(arr, n);
//}


//2

//#include <iostream>
//
//using std::cin;
//using std::cout;
//
//int main()
//{
//	int n;
//	cin >> n;
//	int* arr = new int[n+1];
//	arr[0] = 0;
//	for (int i = 1; i <= n; i++)
//		cin >> arr[i];
//	for (int i = 2; i <= n; i++)
//		arr[i] = std::max(arr[i] + arr[i - 1], arr[i] + arr[i - 2]);
//	cout << arr[n];
//}

//3
#include <iostream>
#include <vector>
#include <climits>

int main() {
    int N;
    std::cin >> N;
    std::vector<int> steps(N + 1, INT_MAX);
    steps[N] = 0;
    std::vector<int> next_num(N + 1, -1);

    for (int i = N; i > 1; --i) {
        int s = steps[i] + 1;
        // 3 * x
        if (!(i % 3) && steps[i / 3] > s) {
            steps[i / 3] = s;
            next_num[i / 3] = i;
        }
        // 2 * x
        if (!(i % 2) && steps[i / 2] > s) {
            steps[i / 2] = s;
            next_num[i / 2] = i;
        }
        // x + 1
        if (steps[i - 1] > s) {
            steps[i - 1] = s;
            next_num[i - 1] = i;
        }
    }

    std::cout << steps[1] << std::endl;
    for (int i = 1; i != -1; i = next_num[i])
        std::cout << i << ' ';
    std::cout << std::endl;
}