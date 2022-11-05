#include<stdio.h>
#include<iostream>
int swapp(int& x, int& y);
void test();
int area(int x, int y);
float area(float x, float y);
float area(float b, float h, int triangle);
using namespace std;
int main()
{
	//test();
	int a = 3;
	int b = 8;
	//swapp(a, b);
	float aa = area(2.0f, 3.0f, 1);
	cout << aa;
	return 0;
}

int swapp(int& x, int& y)
{
	int* p = &x;
	
	int temp;
	temp = x;
	x = y;
	y = temp;
	return 0;
}
void test()
{
	double double_value{ 12.34 };
	double& ref_double_value{ double_value }; // Reference to double_value
	double* p_double_value{ &double_value }; //Pointer to double_value

	//Reading
	std::cout << "double_value : " << double_value << std::endl;
	std::cout << "ref_double_value : " << ref_double_value << std::endl;
	std::cout << "p_double_value : " << p_double_value << std::endl;
	std::cout << "*p_double_value : " << *p_double_value << std::endl;
	

}

int area(int x, int y)
{
	int area = x * y;
	return area;
}
float area(float x, float y)
{
	int area = x * y;
	return area;
}
float area(float b, float h, int triangle)
{
	int area = 0.5* b * h;
	return area;
}