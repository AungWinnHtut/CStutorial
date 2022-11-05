#include<stdio.h>
int main6()
{
	int arr[5] = { 1,2,3,4,5 };
	int* ptr1;
	int* ptr2;	
	ptr1 = &arr[0];
	ptr2 = ptr1 + 3;

	printf("The address of index 0 is %p\n", ptr2);
	int offset = ptr2 - ptr1;
	printf("The offset of two pointer is %d\n", offset);
	return 0;
}