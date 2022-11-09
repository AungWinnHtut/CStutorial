#include<stdio.h>
int main4()
{
	int iArray[5] = {1,2,3,4,5};
	int* iP = iArray;
	
	printf("IP = %x\n",iP);
	printf("value point by IP = %d\n", *(iP+150));
	
	return 0;
}