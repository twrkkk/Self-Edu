#include <iostream>
#include <fstream>
#include <string>
#include <queue>

using std::cin;
using std::cout;

using TInfo = char;
struct NODE
{
	TInfo info;
	NODE* left, * right;
	int frequency = 1;
	NODE() {}
	NODE(TInfo info, int frequency, NODE* left = nullptr, NODE* right = nullptr) : info(info), left(left), right(right), frequency(frequency) {}
	~NODE()
	{
		left = nullptr;
		right = nullptr;
	}
};

using Tree = NODE*;

size_t find_min_elem_index(Tree* trees)
{
	size_t index = 1;
	size_t result = 0;
	int min = trees[0]->frequency;
	while (trees[index] != nullptr && index < 26)
	{
		if (trees[index]->frequency < min)
		{
			min = trees[index]->frequency;
			result = index;
		}
		index++;
	}
	return result;
}

void shift_tail_array(Tree* trees, size_t index)
{
	size_t i = index + 1;
	while (trees[i])
	{
		trees[i - 1] = trees[i];
		i++;
	}
	trees[--i] = nullptr;
}

void push_back(Tree* trees, Tree elem)
{
	size_t i = 0;
	while (trees[i])
		++i;
	trees[i] = elem;
}

bool empty(Tree* trees)
{
	return trees[0] == nullptr;
}

void haffman(Tree root, std::string kode, std::vector<std::pair<char, std::string>>& v)
{
	if (root)
	{
		if (!root->left && !root->right)
		{
			std::pair<char, std::string> pair;
			pair.first = root->info;
			pair.second = kode;
			v.push_back(pair);
		}

		//haffman(root->left, root->info == NULL ? kode : kode + root->info, v);
		//haffman(root->right, root->info == NULL ? kode : kode + root->info, v);
		haffman(root->left, kode + std::to_string(0), v);
		haffman(root->right, kode + std::to_string(1), v);
	}
}

std::string find_code(std::vector<std::pair<char, std::string>>& v, char c)
{
	for (auto elem : v)
	{
		if (elem.first == c)
			return elem.second;
	}
	return "";
}

int main()
{
	size_t freq_dictionary[26] = { 0 };
	std::string input;
	cin >> input;
	for (size_t i = 0; i < input.length(); i++)
		++freq_dictionary[input[i] - 'a'];

	//for (size_t i = 0; i < 26; i++)
	//{
	//	if (freq_dictionary[i] > 0)
	//	{
	//		cout << (char)('a' + i) << " : " << freq_dictionary[i] << '\n';
	//		//trees[index++] = new NODE((char)'a' + i, freq_dictionary[i]);
	//	}
	//}

	Tree* trees = new Tree[26]();
	for (size_t i = 0; i < 26; i++)
	{
		trees[i] = nullptr;
	}

	size_t index = 0;

	for (size_t i = 0; i < 26; i++)
	{
		if (freq_dictionary[i] > 0)
		{
			//cout << (char)('a' + i) << " : " << freq_dictionary[i] << '\n';
			trees[index++] = new NODE((char)'a' + i, freq_dictionary[i]);
		}
	}

	Tree root(0);
	while (!empty(trees))
	{
		int i = 0;
		Tree first(0), second(0);
		i = find_min_elem_index(trees);
		first = trees[i];
		shift_tail_array(trees, i);

		if (!empty(trees))
		{
			i = find_min_elem_index(trees);
			second = trees[i];
			shift_tail_array(trees, i);
		}

		if (first && second)
			root = new NODE(NULL, first->frequency + second->frequency, first, second);
		else if (first)
			root = new NODE(NULL, first->frequency, first, second);

		if (!empty(trees))
			push_back(trees, root);
	}

	std::vector<std::pair<char, std::string>> v;
	haffman(root, "", v);

	std::string result = "";

	for (size_t i = 0; i < input.length(); i++)
	{
		result += find_code(v, input[i]);
	}

	cout << v.size() << ' ' << result.length() << '\n';

	for (auto elem : v)
	{
		cout << elem.first << ':' << ' ' << elem.second << '\n';
	}

	cout << result;
}

