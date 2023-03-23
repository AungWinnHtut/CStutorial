#include<iostream>
#include<conio.h>
using namespace std;
struct CV {
	char name[20];
	int age;
	char phone[20];
};
int cv();

int main()
{
	char ch = '\0';
	char dh = '\0';
	char eh = '\0';
	cout << "Enter two Char " << endl;
	ch = _getch();
	dh = _getch();


	cout << "ch = " << int(ch) << endl << "dh = " << int(dh) << endl;

	return 0;
}


int cv()
{
	int num[5] = { 0 };
	for (int i = 0; i < 5; i++)
	{
		num[i] = 100;
	}
	struct CV mycv;
	return 0;
}