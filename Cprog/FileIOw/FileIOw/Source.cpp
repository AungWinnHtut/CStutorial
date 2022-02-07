#include<stdio.h>
#include<stdlib.h>
#include<iostream>
using std::cout;
using std::endl;
using std::cin;
int main()
{
	FILE* fin;

	float r = 22;
	float a = 0.0;
	a = 3.14 * r * r;
	cout << "testing \a" << endl;
	cout << a << endl;
	fopen_s(&fin, "d:\\test\\test.txt", "a");
	fprintf_s(fin, "\nThe area is %f ",a);
	fclose(fin);

	system("notepad d:\\test\\test.txt");

	return 0;
}