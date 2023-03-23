#include<stdio.h>
#define SIZE 8
int bargraph()
{
	int values[SIZE] = {12,13,20,5,2,17,16,10};
	printf("Index\tValue\tBar\n");
	for (int i = 0; i < SIZE; i++)
	{
		printf("%d\t%d\t", i, values[i]);
		for (int k = 0; k < values[i]; k++)
		{
			printf("*");
		}
		printf("\n");
	}
	return 0;
}