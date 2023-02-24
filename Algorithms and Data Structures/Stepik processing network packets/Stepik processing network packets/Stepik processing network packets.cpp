#include <iostream>
#include <queue>
#include <string>

using std::cin;
using std::cout;
using pair = std::pair<int, int>;

int main()
{
	int buffer_size, packets_count;
	cin >> buffer_size >> packets_count;
	std::queue<pair> q;
	int start_time = -1, finish_time = -1;

	int arrive, duration;
	int index = 1;

	std::string result = "";

	cin >> arrive >> duration;
	q.push(pair(arrive, duration));
	start_time = std::max(finish_time, arrive);
	finish_time = start_time + duration;
	result += std::to_string(start_time) + '\n';
	cin >> arrive >> duration;
	if (arrive >= finish_time)
		q.pop();

	while (index < packets_count)
	{

		if (arrive >= finish_time && q.size() < buffer_size)
		{
			cin >> arrive >> duration;
			q.push(pair(arrive, duration));
			start_time = std::max(finish_time, arrive);
			finish_time = start_time + duration;
			result += std::to_string(start_time) + '\n';
		}
		else
		{
			result += std::to_string(-1) + '\n';
		}

		q.pop();
		index++;
	}
	cout << result;
}
