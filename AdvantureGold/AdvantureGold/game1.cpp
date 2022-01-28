#include<stdio.h>
#include<conio.h>
int fun();

int a = 10;

int main()
{

	char ch = '\0';
	char ans[50] = { '\0' };
	int count = 0;
	fun();
	
	printf("what is your name : ");

	while ((ch = _getch()) != 13)
	{
		putchar(ch);
		ans[count++] = ch;
	}

	int i = 0;
	putchar('\n');
	while(ans[i] != '\0')
	{
		putchar(ans[i]);
		i++;
	}

	return 0;
}

int fun()
{
	int k=999;
	return 0;
}