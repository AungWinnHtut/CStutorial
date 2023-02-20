#include<stdio.h>
int main()
{
	int j[10];
	for (int i = 0; i < 10; i++) //0-9
	{
		j[i] =( i+1)*2;		
	}
	for (int k = 0; k < 10; k++)
	{
		printf("%d\t", j[k]);
	}
	

	return 0;
}