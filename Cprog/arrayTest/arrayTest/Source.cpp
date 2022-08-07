#include<stdio.h>
int main()
{
	int arr[5]={1,2,3,4,5};
	for (int i=0; i < 5; i++)
	{
		printf("%x /t arr[%d] = %d\n",&arr[i],i, arr[i]);
	}
	printf("\n\n");
	printf("array name is %d \n",*arr);
	printf("address of first index %x", *&arr[2]);
	
	return 0;
}