#include<stdio.h>
int checkint()
{
	int i = 0;
	printf("Please enter an integer: ");
	scanf_s("%d", &i);
	//determine whether the input integer is negative, positive or zero
	if (i == 0)
	{
		printf("it is zero\n");
	}
	else if (i < 0)
	{
		printf("it is negative\n");
	}
	else
	{
		printf("it is positive\n");
	}

	return 0;
}