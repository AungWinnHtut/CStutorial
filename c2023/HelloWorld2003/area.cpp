#include<stdio.h>
int area()
{
	//Input storatge
	float L = 0.0;
	float W = 0.0;
	//Output storage
	float A = 0.0;

	printf("Please enter L: ");
	scanf_s("%f", &L);

	printf("Please enter W: ");
	scanf_s("%f", &W);

	A = L * W;

	printf("Area = %0.2f", A);

	return 0;
}