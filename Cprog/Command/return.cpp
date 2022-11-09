#include<stdio.h>
int add(int a, int b);
int main3()
{
	int result = add(0, 5);
	printf("the sum of 2 and 5 is %d", result );
	return 0;
}

int add(int a, int b)
{
	int sum = 0;
	if (a == 0)
	{
		return 0;
	}
	sum = a + b;
	return sum;
}