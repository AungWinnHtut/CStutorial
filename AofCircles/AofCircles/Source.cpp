#include<stdio.h>
#include<sys/types.h>


#define LIMIT 5
int funLine(int x, int m, int c);

int main()
{
	for (int x = 0; x < 100; x++)
	{
		printf(" x = %d - y = %d \n", x, funLine(x, 3, 0));
	}

	return 0; //0 means OK
}



int main1()
{
	float r[LIMIT] = { 1.2,2.3,3.4,5.6,9.8 };
	float A[LIMIT] = { 0.0f };

	for (int i = 0; i < LIMIT; i++)
	{
		A[i] = 3.14 * r[i] * r[i];
	}

	
	for (int i = 0; i < LIMIT; i++)
	{
		printf("The area is %f \n", A[i]);
	}


	return 0;
}