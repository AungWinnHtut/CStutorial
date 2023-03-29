#include<iostream>
#include<vector>


using namespace std;
void swap(int &a, int &b);
int main()
{
	vector<int> numbers = { 1,2,3,4,5 };
	for (const int &i : numbers)
	{
		cout << i << endl;
	}
	
	return 0;
}

void swap(int &a, int &b)
{
	int temp = a;
	a = b;
	b = temp;
}

void print(const int& a, const int& b)
{
	cout << a << b << endl;
}