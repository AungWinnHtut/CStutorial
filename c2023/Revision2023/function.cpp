#include<stdio.h>
 //fun declaration
float funCalArea(float R);
float funCalVol(float R, float h);

int function()
{
	//calling fun, invoking fun
	float Vol = funCalVol(23.4,22.1);
	printf("vol = %f", Vol);
	return 0;
}

float funCalArea(float R) //fun definition
{
	float A = 0.0;	
	A = 3.14 * R * R;
	return A;
}

float funCalVol(float R, float h)
{
	float Area = funCalArea(R);
	float V = Area * h;
	return V;
}