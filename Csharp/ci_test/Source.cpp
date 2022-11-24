#include<stdio.h>
#include<string.h>
char* gets2(char* str);


int main()
{
	char ch = '\0';
	char uname[20];
	int i = 0;
	printf("please enter username: ");
	gets2(uname);
	
	//hard coded string , string lateral
	if (strcmp(uname, "aung win htut\n")==0)
	{
		printf("username is correct! \n");
	}
	return 0;
}

char* gets2(char* str)
{
	char ch = '\0';
	int i = 0;
	do {
		ch = getc(stdin);
		str[i++] = ch;
	} while (ch != '\n');
	str[i] = '\0';
	return str;
}