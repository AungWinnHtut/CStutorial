#include<stdio.h>
#include"Area.h"

//function definition
float calculateArea(float R, float H)
{
	//1. Var Declaratioon
	//Outputs
	float A = 0.0;
	float V = 0.0;

	//Processing
	A = pi * R * R;
	V = A * H;

	//Printing Outputs
	printf("Area = %0.2f and Volume = %0.2f\n\n", A, V);
	return A;
}