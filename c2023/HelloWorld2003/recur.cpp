#include<stdio.h>
#include<stdlib.h>
void recursion();
int count = 0;
int recur()
{
	recursion();
	return 0;
}

void recursion()
{
	float k = 23.4;	
	printf("%d\t", count++);	
	recursion();	
}