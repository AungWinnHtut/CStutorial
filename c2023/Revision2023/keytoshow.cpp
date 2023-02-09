#include<stdio.h>
int keytoshow()
{
	printf("Enter a key to show\n");
	printf("==============\n");
	char ch = NULL;
	do {
		ch = fgetc(stdin);
		if (ch != '\n')
		{
			printf(" %d\n", ch);
		}
		
	} while (ch != 27);

	return 0;
}