#include<stdio.h>
int main()
{
	int data[20] = { 1,	2,	5,	4,	3,	5,	2,	1,	3,	1,	4,	3,	3,	3	,2,	3,	3,	2,	2	,5 };
	int freq[6] = { 0 };
	//freq[0] = one
	//freq[1] = two
	int one = 0;
	int two = 0;
	int three = 0;
	int four = 0;
	int five = 0;
	for (int i = 0; i < 20; i++)
	{
		++freq[data[i]];
	}

	for (int j = 1; j < 6; j++)
	{
		printf("frequency of %d = %d\n", j,freq[j]);
	}

	return 0;
}