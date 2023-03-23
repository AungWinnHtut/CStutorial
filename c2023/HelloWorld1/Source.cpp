#include<iostream>
using namespace std;
unsigned long int pow_k(int x, int y);
int main()
{
	 //x**y   y = 4   x * x * x * x
	unsigned long int x=0;
	unsigned long int y=0;
	unsigned long int p=0;
	cout << "Enter x: ";
	cin >> x;
	cout << "Enter y: ";
	cin >> y;
	p = pow_k(x, y);
	cout << "x power y is " << p << endl << endl;
	return 0;
}

unsigned long int pow_k(int x, int y)
{
	unsigned long int pow=1;
	for (int i = 1; i <= y; i++)
	{
		pow = pow * x;
	}
	return pow;
}

