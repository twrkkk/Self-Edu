/*
В первой строке задано два целых числа 1 \le n \le 500001≤n≤50000 и 1 \le m \le 500001≤m≤50000 — количество отрезков и точек на прямой, соответственно. Следующие nn строк содержат по два целых числа a_ia
i
​
  и b_ib
i
​
  (a_i \le b_ia
i
​
 ≤b
i
​
 ) — координаты концов отрезков. Последняя строка содержит mm целых чисел — координаты точек. Все координаты не превышают 10^810
8
  по модулю. Точка считается принадлежащей отрезку, если она находится внутри него или на границе. Для каждой точки в порядке появления во вводе выведите, скольким отрезкам она принадлежит.





Sample Input:

2 3
0 5
7 10
1 6 11
Sample Output:

1 0 0
*/

#include <iostream>
#include <functional>

using std::cin;
using std::cout;

void qSort(int* mas, int size) {
	int i = 0;
	int j = size - 1;

	int mid = mas[size / 2];

	do {
		while (mas[i] < mid) {
			i++;
		}
		while (mas[j] > mid) {
			j--;
		}

		if (i <= j) {
			int tmp = mas[i];
			mas[i] = mas[j];
			mas[j] = tmp;

			i++;
			j--;
		}
	} while (i <= j);


	if (j > 0) {
		qSort(mas, j + 1);
	}
	if (i < size) {
		qSort(&mas[i], size - i);
	}
}

int count_elems(int* arr, int size, int key, std::function<bool(int, int)> comp)
{
	int result = 0;
	for (int i = 0; i < size; i++)
		if (comp(arr[i], key))
			++result;
		else return result;
	return result;
}

int main()
{
	int segment_count, points_count;
	cin >> segment_count >> points_count;

	int* starts = new int[segment_count];
	int* ends = new int[segment_count];

	for (int i = 0; i < segment_count; i++)
	{
		cin >> starts[i];
		cin >> ends[i];
	}

	int* points = new int[points_count];
	for (int i = 0; i < points_count; i++)
		cin >> points[i];

	qSort(starts, segment_count);
	qSort(ends, segment_count);

	auto less_equals = [](int l, int r) {return l <= r; };
	auto less = [](int l, int r) {return l < r; };
	for (int i = 0; i < points_count; i++)
	{
		//do algorithm
		int N = count_elems(starts, segment_count, points[i], less_equals);
		int M = count_elems(ends, segment_count, points[i], less);

		cout << N - M << ' ';
	}
}
