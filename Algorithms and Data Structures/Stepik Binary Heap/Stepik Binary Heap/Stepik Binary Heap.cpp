#include <iostream>
#include <fstream>
#include <string>
#include <queue>


using TInfo = int;
struct NODE
{
	TInfo info;
	NODE* left, * right, * parent;
	NODE() {}
	NODE(TInfo info, NODE* parent = nullptr, NODE* left = nullptr, NODE* right = nullptr) : info(info), parent(parent), left(left), right(right) {}
	~NODE()
	{
		left = nullptr;
		right = nullptr;
		parent = nullptr;
	}
};

using Tree = NODE*;

void build_heap(Tree t, TInfo elem)
{

}

void Print(Tree t, int level)
{
	if (t)
	{
		Print(t->right, level + 1);
		for (int i = 0; i < level; i++)
			std::cout << ' ';
		std::cout << t->info << '\n';
		Print(t->left, level + 1);
	}
}

int main()
{
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << '*';
	}
	std::cout << '\n';
	for (size_t i = 0; i < 10; i++)
	{
		for (size_t j = 0; j < 10; j++)
		{
			if (i == j || i + j == 9) 
				std::cout << '*';
			else
				std::cout << ' ';
		}
		std::cout << '\n';
	}
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << '*';
	}
}