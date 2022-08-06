#include<stdio.h>

void rec(int i);

int main()
{
	rec(1);
}

void rec(int i)
{
	double d;
	double d1;
	double d2;
	double d3;
	double d4;
	double d5;
	double d6;
	if (i == -1)
	{
		printf("\n\n");
		return;
	}
	else {
		printf("Hello : %d\n", i);
		rec(i + 1);
	}
	
	
}