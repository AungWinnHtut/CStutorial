#include<stdio.h>
int basicio()
{
	//storage
	printf("First Values\n");
	printf("===========\n");
	int i = 10;
	float f = 33.4;
	char ch = 'a';
	printf("i=%d\n", i);
	printf("f=%f\n", f);
	printf("ch=%c - %d\n", ch,ch);
	printf("Second Values\n");
	printf("===========\n");
	i = 20;
	f = 55.6;
	ch = 'k';
	printf("i=%d\n", i);
	printf("f=%f\n", f);
	printf("ch=%c - %d\n", ch, ch);
	//processing arithmetic operation + - * / % , logical operation > < == != 
	printf("Processed Values\n");
	printf("===========\n");
	i = 20+34;
	f = 55.6*4.7;
	ch = 'k'+3;
	printf("i=%d\n", i);
	printf("f=%f\n", f);
	printf("ch=%c - %d\n", ch, ch);
	//Input
	printf("Please enter an integer: ");
	scanf_s("%d", &i);
	printf("Please enter a float: ");
	scanf_s("%f", &f);
	printf("Please enter a char: ");
	scanf_s("%c", &ch, (unsigned int)sizeof(ch));
	if (ch == '\n')
	{
		scanf_s("%c", &ch, (unsigned int)sizeof(ch));
	}

	printf("i=%d\n", i);
	printf("f=%f\n", f);
	printf("ch=%c - %d\n", ch, ch);
	//output
	printf("Hello World");
	
	
	
	return 0;
}