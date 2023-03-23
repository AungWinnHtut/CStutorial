#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<conio.h>

#define HELLO printf("Hello\n")
#define PI 3.1415
#define SIZE 3

int area()
{
	HELLO;
	float r[SIZE] = { 0.0 };
	float a[SIZE] = { 0.0 };
	for (int i = 0; i < SIZE; i++)
	{
		printf("Please enter radius: ");
		scanf_s("%f", &r[i]);
		a[i] = PI * r[i] * r[i]; // a = 3.14 * r * r ;
		printf("The area is %f \n", a[i]);
	}
	
	
	



	return 0;
}