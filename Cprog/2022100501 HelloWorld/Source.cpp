#include<stdio.h>
int main()
{
	int width = 0;
	int length = 0;
	int area = 0;
	//Asking inputs
	printf("please enter width : ");
	scanf_s("%d", &width);  //address of width  scanf()

	printf("please enter Length : ");
	scanf_s("%d", &length);  //address of width  scanf()
	///
	area = length * width; // + - * / %
	printf("The area is %d\n", area);	
	return 0;
}