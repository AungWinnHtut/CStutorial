#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<conio.h>
int main()
{
	int age[5] = { 0 };
	char ch[5] = {'\0'};
	float f[5] = { 0.0 };
	int i = 0;
	i = 4;
	age[0] = 4;
	char c = '\0';
	c = 'a';
	ch[0] = 'a';
	float ff = 0.0;
	ff = 3.44;

	scanf_s("%d", &i);
	scanf_s("%d", &age[0]);

	scanf_s("%c", &c, 1);
	scanf_s("%c", &ch[0],1);
	scanf_s("%s", ch, 5);

	//h == &ch == &ch[0];



	return 0;
}