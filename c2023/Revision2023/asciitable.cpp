#include<stdio.h>
int asciitable()
{
	printf("ASCII table\n");
	printf("==============\n");
	for (int i = 0; i <= 255; i++)
	{
		printf("%d - %o - %x - %c\n", i,i,i,i);
	}
	
	return 0;
}