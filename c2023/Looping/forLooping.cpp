#include<stdio.h>

int forLooping()
{
	float Tc;	
	float Tf = 0;
	printf("Tc\t\tTf\n");
	printf("====\t\t====\n");
	for (int i = 0; i < 101; i++) //iterator, looping counter
	{
		Tc = i;
		Tf=((Tc*9)/5)+32;
		printf("%f\t%f\n", Tc,Tf);
	}


	
	return 0;
}