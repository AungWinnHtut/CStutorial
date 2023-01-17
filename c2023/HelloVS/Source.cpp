#include<stdio.h>
int main()
{
	float age1 = 0.0;
	float age2 = 0.0;
	printf("Please enter age1 : ");
	scanf_s("%f", &age1);

	printf("Please enter age2 : ");
	scanf_s("%f", &age2);

	float age = age1 / age2;
	int length;
	length = 20;
	float weight = 65.7;
	char alphabet = 'a';
	printf("Hello World!\nI am Aung Win Htut\n");
	printf("age = %f\n",age);
	return 0;
}