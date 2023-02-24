//#include <cassert>
//#include <iostream>
//
//class Fibonacci {
//public:
//	static int get(int n) {
//		if (n == 0)
//			return n + 1;
//		else if (n == 1)
//			return n;
//		else if (n >= 2)
//			return get(n - 1) + get(n - 2);
//	}
//};
//
//int main(void) {
//	int n;
//	std::cin >> n;
//	std::cout << Fibonacci::get(n-1) << std::endl;
//	return 0;
//}

//#include <cassert>
//#include <iostream>
//
//class Fibonacci final {
//public:
//	static int get_last_digit(int n) {
//		int* arr = new int[n];
//		arr[0] = 1;
//		arr[1] = 1;
//		for (int i = 2; i < n; ++i)
//		{
//			arr[i] = (arr[i - 1] % 10 + arr[i - 2] % 10) % 10;
//		}
//		return arr[n - 1];
//	}
//};
//
//int main(void) {
//	int n;
//	std::cin >> n;
//	//for (size_t i = 0; i < n; i++)
//	{
//		std::cout << Fibonacci::get_last_digit(n) << std::endl;
//
//	}
//	return 0;
//}

//#include <cassert>
//#include <cstdint>
//#include <iostream>
//
//class Fibonacci final {
//public:
//    static int get_remainder(long long n, long long m) {
//        assert(n >= 1);
//        assert(m >= 2);
//        int size = std::max(n, m);
//        long long* arr = new long long[size];
//        arr[0] = 1;
//        arr[1] = 1;
//        for (long long i = 2; i < size; i++)
//        {
//            arr[i] = arr[i - 1] + arr[i - 2];
//        }
//        return arr[n] % arr[m];
//    }
//};
//
//int main(void) {
//    long long n;
//    long long m;
//    std::cin >> n >> m;
//    std::cout << Fibonacci::get_remainder(n, m) << std::endl;
//}

//#include <cassert>
//#include <iostream>
//
//class Fibonacci {
//public:
//	static int get(int n) {
//		int prev = 0, curr = 1;
//		for (int i = 0; i < n; i++)
//		{
//			int newCurr = prev + curr;
//			prev = curr;
//			curr = newCurr;
//		}
//		return curr;
//	}
//};
//
//int main(void) {
//	int n;
//	std::cin >> n;
//	std::cout << Fibonacci::get(n-1) << std::endl;
//	return 0;
//}

//#include <cassert>
//#include <cstdint>
//#include <iostream>
//
//template <class Int>
//Int gcd(Int a, Int b) {
//
//	while (a > 0 && b > 0)
//	{
//		if (a > b)
//			a %= b;
//		else
//			b %= a;
//	}
//
//	return a == 0 ? b : a;
//}
//
//int main(void) {
//	std::int32_t a, b;
//	std::cin >> a >> b;
//	std::cout << gcd(a, b) << std::endl;
//	return 0;
//}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//#include <iostream>
//#include <utility>
//#include <vector>
//#include <algorithm>
//
//typedef std::pair <int, int> Segment;
//
//std::vector <int> get_covering_set(std::vector <Segment> segments) {
//	std::vector <int> result;
//
//	std::sort(segments.begin(), segments.end(), [](Segment first, Segment second) {return first.second < second.second; });
//
//	int beg = -1;
//	for (auto s : segments) {
//		if (beg < s.first) {
//			beg = s.second;
//			result.push_back(beg);
//		}
//	}
//
//	return result;
//}
//
//int main(void) {
//	int segments_count;
//	std::cin >> segments_count;
//	std::vector <Segment> segments(segments_count);
//	for (int i = 0; i < segments_count; i++) {
//		std::cin >> segments[i].first >> segments[i].second;
//	}
//
//	std::vector <int> points = get_covering_set(segments);
//	std::cout << points.size() << std::endl;
//	for (std::size_t i = 0; i < points.size(); i++) {
//		std::cout << points[i] << " ";
//	}
//	std::cout << std::endl;
//}

//#include <iostream>
//#include <vector>
//#include <algorithm>
//#include <iomanip>
//
//struct data
//{
//public:
//	int cost, volume;
//	double cv;
//};
//
//float max_price(int n, int W, std::vector<data>& d)
//{
//	std::sort(d.begin(), d.end(), [](data data1, data data2) {return data1.cv > data2.cv; });
//
//	double result = 0;
//	double cur_volume = 0;
//	bool flag = false;
//
//	int index = 0;
//	while (!flag)
//	{
//		if (d[index].volume <= W - cur_volume)
//		{
//			result += d[index].cost;
//			cur_volume += d[index].volume;
//			//d.erase(d.begin());
//		}
//		else
//		{
//			double delta = ((double)W - cur_volume) / d[index].volume;
//			result += d[index].cost * delta;
//			cur_volume += d[index].volume * delta;
//		}
//		if (((double)W - cur_volume) < 0.001)
//			flag = true;
//		++index;
//	}
//
//	return result;
//}
//
//int main()
//{
//	int n, W, cost, volume;
//
//	std::cin >> n >> W;
//
//	std::vector<data> Data(n);
//
//	data d;
//
//	for (size_t i = 0; i < n; i++)
//	{
//		std::cin >> cost >> volume;
//		d.cost = cost;
//		d.volume = volume;
//		d.cv = (double)cost / volume;
//		Data[i] = d;
//	}
//
//	std::cout << std::fixed << std::setprecision(3) << max_price(n, W, Data);
//}

//#include <cassert>
//#include <cstdint>
//#include <iostream>
//#include <vector>
//#include <algorithm>
//
//struct Item final {
//    int weight;
//    int value;
//    double cv;
//};
//
//double get_max_knapsack_value(int capacity, std::vector <Item> items) {
//    double value = 0.0;
//
//    // take items while there is empty space in knapsack
//    for (auto& item : items) {
//        if (capacity > item.weight) {
//            // can take full item and continue
//            capacity -= item.weight;
//            value += item.value;
//        }
//        else {
//            value += item.value * (static_cast <double>(capacity) / item.weight);
//            break;
//        }
//    }
//
//    return value;
//}
//
//int main(void) {
//    int number_of_items;
//    int knapsack_capacity;
//    std::cin >> number_of_items >> knapsack_capacity;
//    std::vector <Item> items(number_of_items);
//    for (int i = 0; i < number_of_items; i++) {
//        std::cin >> items[i].value >> items[i].weight;
//        items[i].cv = (double)items[i].value / items[i].weight;
//    }
//
//    std::sort(items.begin(), items.end(), [](Item data1, Item data2) {return data1.cv > data2.cv; });
//
//    double max_knapsack_value = get_max_knapsack_value(knapsack_capacity, std::move(items));
//
//    std::cout.precision(10);
//    std::cout << max_knapsack_value << std::endl;
//    return 0;
//}

#include <iostream>
#include <string>

int main()
{
	int n, k = 0;
	std::string result = "";

	std::cin >> n;

	int i = 1;
	while (n > i * 2)
	{
		n -= i;
		result += std::to_string(i) + " ";
		++k;
		++i;
	}

	result += std::to_string(n);
	++k;

	std::cout << k << '\n' << result;
}